/*
 * Created by SharpDevelop.
 * User: roque.possamai
 * Date: 18/07/2019
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Text;
using MyNotesFree.database.entity;

namespace MyNotesFree.database.dao
{
	/// <summary>
	/// Description of AnnotationDAO.
	/// </summary>
	public class AnnotationDAO: IAnnotationDAO
	{
		public AnnotationDAO()
		{
			
		}
		
		public Annotation buildObject(SQLiteDataReader res)
		{
			
			Annotation note = new Annotation();
			note.Id = res.GetInt16(res.GetOrdinal("id"));
			note.Title = (string)res["title"];

			//Há situações em que o texto não é selecionado
			if (res.GetOrdinal("text") > -1) {
				byte[] text = GetBytes("text", res);
				text = Encoding.Convert(Encoding.GetEncoding("iso-8859-1"), Encoding.UTF8, text);
				note.Text = Encoding.UTF8.GetString(text, 0, text.Length);
			}
			
			if (res.GetOrdinal("size") > -1) {
				note.Size = res.GetInt32(res.GetOrdinal("size"));
			}

			note.CreatedAt = converToDateTime((string)res["createdAt"]); //createdAt
			note.UpdatedAt = converToDateTime((string)res["updatedAt"]); //updatedAt
			note.CategoryId = res.GetInt16(res.GetOrdinal("categoryId")); //categoryId
			note.Position = res.GetInt32(res.GetOrdinal("position")); //position
			note.Password = (res["password"] != DBNull.Value ? (string)res["password"] : null);

			return note;
		}
		
		private DateTime converToDateTime(string dateTime)
		{
			var values = dateTime.Split('-');
			return new DateTime(int.Parse(values[0]), int.Parse(values[1]), int.Parse(values[2]), int.Parse(values[3]), int.Parse(values[4]), int.Parse(values[5]));
		}

		#region IAnnotationDAO implementation
		public void update(Annotation annotation)
		{
			var cmd = DBAccess.getCommand("update note set id = @id, title = @title, createdAt = @createdAt, updatedAt = @updatedAt, text = @text, categoryId = @categoryId, position = @position where id = @id");
			var pId = new SQLiteParameter("@id", annotation.Id);
			var pTitle = new SQLiteParameter("@title", annotation.Title);
			var pCreatedAt = new SQLiteParameter("@createdAt", annotation.CreatedAt.ToString("yyyy-MM-dd-hh-mm-ss"));
			var pUdatedAt = new SQLiteParameter("@updatedAt", annotation.UpdatedAt.ToString("yyyy-MM-dd-hh-mm-ss")); 
			var pText = new SQLiteParameter("@text", annotation.Text);
			var pCategoryId = new SQLiteParameter("@categoryId", annotation.CategoryId);
			var pPosition = new SQLiteParameter("@position", annotation.Position); 
			cmd.Parameters.Add(pId);
			cmd.Parameters.Add(pTitle);
			cmd.Parameters.Add(pCreatedAt);
			cmd.Parameters.Add(pUdatedAt);
			cmd.Parameters.Add(pText);
			cmd.Parameters.Add(pCategoryId);
			cmd.Parameters.Add(pPosition);
			
			cmd.ExecuteNonQuery();
		}

		public void insert(Annotation annotation)
		{
			var cmd = DBAccess.getCommand("insert into note (id, title, createdAt, updatedAt, text, categoryId, position) values (@id, @title, @createdAt, @updatedAt, @text, @categoryId, @position)");
			var pCodNote = new SQLiteParameter("@id", annotation.Id);
			var pTitNote = new SQLiteParameter("@title", annotation.Title);
			var pDatCriacao = new SQLiteParameter("@createdAt", annotation.CreatedAt.ToString("yyyy-MM-dd-hh-mm-ss"));
			var pDatAlteracao = new SQLiteParameter("@updatedAt", annotation.UpdatedAt.ToString("yyyy-MM-dd-hh-mm-ss")); 
			var pTexNote = new SQLiteParameter("@text", annotation.Text);
			var pCodCateg = new SQLiteParameter("@categoryId", annotation.CategoryId);
			var pPosition = new SQLiteParameter("@position", annotation.Position);
			cmd.Parameters.Add(pCodNote);
			cmd.Parameters.Add(pTitNote);
			cmd.Parameters.Add(pDatCriacao);
			cmd.Parameters.Add(pDatAlteracao);
			cmd.Parameters.Add(pTexNote);
			cmd.Parameters.Add(pCodCateg);
			cmd.Parameters.Add(pPosition);
			
			cmd.ExecuteNonQuery();
		}

		public void delete(int id)
		{
			SQLiteCommand cmd = DBAccess.getCommand("delete from note where id = @id");
			cmd.Parameters.Add("@id", DbType.Int16).Value = id;
			cmd.ExecuteNonQuery();
		}

		public Annotation get(int id)
		{
			const string sql = "select id, title, text, createdAt, updatedAt, categoryId, password, position from note where id = @id";
			SQLiteCommand cmd = DBAccess.getCommand(sql);
			try {
				Annotation note = null;

				SQLiteParameter pCodNote = new SQLiteParameter("@id", id);
				cmd.Parameters.Add(pCodNote);
				SQLiteDataReader res = cmd.ExecuteReader(CommandBehavior.SequentialAccess);
				try {
					if (res.Read()) {
						note = buildObject(res);
					}
				} finally {
					res.Close();
				}
				       	
				return note;
			} catch (SqlException ex) {
				throw ex;
			}
		}

		/**
		 * Seleciona todos os campos exceto o campo Texto, 
		 * pois o tamanho de todos os textos pode consumir muita memória
		 */
		public List<Annotation> listAll()
		{
			const string sql = "select id, title, '' as text, createdAt, updatedAt, categoryId, Password, length(text) as size, position from note";
			List<Annotation> list = new List<Annotation>();
			
			SQLiteDataReader res = DBAccess.executeQuery(sql);
			try {
				while (res.Read()) {
					list.Add(buildObject(res));
				}
			} finally {
				res.Close();
			}
			return list;
		}

		/**
		 * Retorna todas as anotações conforme categorias selecionadas na base.
		 * Seleciona todos os campos exceto o campo Texto, pois o tamanho de todos os textos pode consumir muita memória
		 */
		public List<Annotation> listAllFiltered()
		{
			const string sql = "select n.id, n.title, '' as text, n.createdAt, n.updatedAt, n.categoryId, n.Password, length(n.text) as size, n.position " + 
				               "from note n, category c where n.categoryId = c.id and c.selected = 1";
			List<Annotation> list = new List<Annotation>();
			
			SQLiteDataReader res = DBAccess.executeQuery(sql);
			try {
				while (res.Read()) {
					list.Add(buildObject(res));
				}
			} finally {
				res.Close();
			}
			return list;
		}

		public System.Collections.Generic.List<Annotation> findInAnnotation(string textToSearch)
		{
			throw new NotImplementedException();
		}

		/**
		 * Cria uma nova anotação de acordo com a categoria selecionada
		 */
		public Annotation createNew(int categoryId)
		{
			var note = new Annotation();
			note.Id = getLastID() + 1;
			note.Title = "";
			note.CreatedAt = DateTime.Now;
			note.UpdatedAt = note.CreatedAt;
			note.CategoryId = categoryId; //TODO: Rever
			note.Text = "";
			insert(note);
			
			return note;
		}

		public int getLastID()
		{
			var cmd = DBAccess.getCommand("select max(id) as id from note");
			var res = cmd.ExecuteScalar();
			if (res != DBNull.Value) {
				return Convert.ToInt16(res);
			}
			return 0;
		}
		#endregion
		
		private byte[] GetBytes(string field, SQLiteDataReader reader)
		{
			const int CHUNK_SIZE = 512 * 1024;
			char[] buffer = new char[CHUNK_SIZE];
			long bytesRead;
			long fieldOffset = 0;
			using (MemoryStream stream = new MemoryStream()) {
				int fieldPos = reader.GetOrdinal(field);
				if (reader.GetValue(fieldPos) != DBNull.Value) {
					while ((bytesRead = reader.GetChars(fieldPos, fieldOffset, buffer, 0, buffer.Length)) > 0) {
						stream.Write(Encoding.Default.GetBytes(buffer), 0, (int)bytesRead);
						fieldOffset += bytesRead;
					}
				}
				return stream.ToArray();
			}
		}

	}
}
