/*
 * Created by SharpDevelop.
 * User: roque.possamai
 * Date: 18/07/2019
 */
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Text;
using MyNotesFree.database.delphi.entity;

namespace MyNotesFree.database.delphi.dao
{
	/// <summary>
	/// Description of AnnotationDAO.
	/// </summary>
	public class DelphiAnnotationDAO: IDelphiAnnotationDAO
	{
		public DelphiAnnotationDAO()
		{
			
		}
		
		public DelphiAnnotation buildObject(SQLiteDataReader res)
		{
			
			DelphiAnnotation note = new DelphiAnnotation();
			note.CodNote = res.GetInt16(res.GetOrdinal("codNote"));
			note.TitNote = (string)res["titNote"];

			//Há situações em que o texto não é selecionado
			if (res.GetOrdinal("TexNote") > -1) {
				byte[] text = GetBytes("TexNote", res);
				text = Encoding.Convert(Encoding.GetEncoding("iso-8859-1"), Encoding.UTF8, text);
				note.TexNote = Encoding.UTF8.GetString(text, 0, text.Length);
			}

			note.CreatedAt = converToDateTime((string)res["DatCriacao"]); //createdAt
			note.UpdatedAt = converToDateTime((string)res["DatAlteracao"]); //updatedAt
			note.CategoryId = res.GetInt16(res.GetOrdinal("CodCateg")); //categoryId
			note.Password = (res["password"] != DBNull.Value ? (string)res["password"] : null);

			return note;
		}
		
		private DateTime converToDateTime(string dateTime) {
			var values = dateTime.Split('-');
			return new DateTime(int.Parse(values[0]), int.Parse(values[1]), int.Parse(values[2]), int.Parse(values[3]), int.Parse(values[4]), int.Parse(values[5]));
		}

		#region IAnnotationDAO implementation
		public void update(DelphiAnnotation annotation)
		{
			var cmd = DBAccess.getCommand("update notes set codNote = @codNote, titNote = @titNote, datCriacao = @datCriacao, datAlteracao = @datAlteracao, texNote = @texNote, codCateg = @codCateg where codNote = @codNote");
			var pCodNote = new SQLiteParameter("@codNote", annotation.CodNote);
			var pTitNote = new SQLiteParameter("@titNote", annotation.TitNote);
			var pDatCriacao = new SQLiteParameter("@datCriacao", annotation.CreatedAt.ToString("yyyy-MM-dd-hh-mm-ss"));
			var pDatAlteracao = new SQLiteParameter("@datAlteracao", annotation.UpdatedAt.ToString("yyyy-MM-dd-hh-mm-ss")); 
			var pTexNote =  new SQLiteParameter("@texNote", annotation.TexNote);
			var pCodCateg =  new SQLiteParameter("@codCateg", annotation.CategoryId);
			cmd.Parameters.Add(pCodNote);
			cmd.Parameters.Add(pTitNote);
			cmd.Parameters.Add(pDatCriacao);
			cmd.Parameters.Add(pDatAlteracao);
			cmd.Parameters.Add(pTexNote);
			cmd.Parameters.Add(pCodCateg);
			
			cmd.ExecuteNonQuery();
		}

		public void insert(DelphiAnnotation annotation)
		{
			var cmd = DBAccess.getCommand("insert into notes (codNote, titNote, datCriacao, datAlteracao, texNote, codCateg) values (@codNote, @titNote, @datCriacao, @datAlteracao, @texNote, @codCateg)");
			var pCodNote = new SQLiteParameter("@codNote", annotation.CodNote);
			var pTitNote = new SQLiteParameter("@titNote", annotation.TitNote);
			var pDatCriacao = new SQLiteParameter("@datCriacao", annotation.CreatedAt.ToString("yyyy-MM-dd-hh-mm-ss"));
			var pDatAlteracao = new SQLiteParameter("@datAlteracao", annotation.UpdatedAt.ToString("yyyy-MM-dd-hh-mm-ss")); 
			var pTexNote =  new SQLiteParameter("@texNote", annotation.TexNote);
			var pCodCateg =  new SQLiteParameter("@codCateg", annotation.CategoryId);
			cmd.Parameters.Add(pCodNote);
			cmd.Parameters.Add(pTitNote);
			cmd.Parameters.Add(pDatCriacao);
			cmd.Parameters.Add(pDatAlteracao);
			cmd.Parameters.Add(pTexNote);
			cmd.Parameters.Add(pCodCateg);
			
			cmd.ExecuteNonQuery();
		}

		public void delete(int codNote)
		{
			throw new NotImplementedException();
		}

		public DelphiAnnotation get(int codNote)
		{
			const string sql = "select * from notes where codNote = @codNote";
			SQLiteCommand cmd = DBAccess.getCommand(sql);
			try {
				DelphiAnnotation note = null;

				SQLiteParameter pCodNote = new SQLiteParameter("@codNote", codNote);
				cmd.Parameters.Add(pCodNote);
				SQLiteDataReader res = cmd.ExecuteReader();
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
		public List<DelphiAnnotation> listAll()
		{
			const string sql = "select CodNote, TitNote, '' as TexNote, DatCriacao, DatAlteracao, CodCateg, Password from notes";
			List<DelphiAnnotation> list = new List<DelphiAnnotation>();
			
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

		public System.Collections.Generic.List<DelphiAnnotation> findInAnnotation(string textToSearch)
		{
			throw new NotImplementedException();
		}

		public DelphiAnnotation createNew(int categoryId)
		{
			var note = new DelphiAnnotation();
			note.CodNote = getLastID() + 1;
			note.TitNote = "";
			note.CreatedAt = DateTime.Now;
			note.UpdatedAt = note.CreatedAt;
			note.CategoryId = categoryId; //TODO: Rever
			note.TexNote = "";
			insert(note);
			
			return note;
		}

		public int getLastID()
		{
			var res = DBAccess.executeQuery("select max(codNote) as codNote from notes");
			if (res.Read()) {
				return (res.GetValue(0) == DBNull.Value ? 0 : res.GetInt16(0));
			}
			return 0;
		}
		#endregion
		
		private byte[] GetBytes(string field, SQLiteDataReader reader)
		{
		    const int CHUNK_SIZE = 2 * 1024;
		    char[] buffer = new char[CHUNK_SIZE];
		    long bytesRead;
		    long fieldOffset = 0;
		    using (MemoryStream stream = new MemoryStream())
		    {
		    	if (reader.GetValue(reader.GetOrdinal(field)) != DBNull.Value) {
			    	while ((bytesRead = reader.GetChars(reader.GetOrdinal(field), fieldOffset, buffer, 0, buffer.Length)) > 0)
			        {
			    		stream.Write(Encoding.Default.GetBytes(buffer), 0, (int)bytesRead);
			            fieldOffset += bytesRead;
			        }
		    	}
		        return stream.ToArray();
		    }
		}

	}
}
