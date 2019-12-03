/*
 * Created by SharpDevelop.
 * User: roque.possamai
 * Date: 23/07/2019
 */
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using MyNotesFree.database.entity;
using System.Data;

namespace MyNotesFree.database.dao
{
	/// <summary>
	/// Description of CategoryDAO.
	/// </summary>
	public class CategoryDAO: ICategoryDAO
	{
		public CategoryDAO()
		{
		}

		#region ICategoryDAO implementation

		public void update(Category category)
		{
			throw new NotImplementedException();
//			cmd = DBAccess.getCommand("set id = @id, title = @title, createdAt = @createdAt, updatedAt = @updatedAt, text = @text, categoryId = @categoryId, position = @position where id = @id");
//			var pId = new SQLiteParameter("@id", annotation.Id);
//			var pTitle = new SQLiteParameter("@title", annotation.Title);
//			var pCreatedAt = new SQLiteParameter("@createdAt", annotation.CreatedAt.ToString("yyyy-MM-dd-hh-mm-ss"));
//			var pUdatedAt = new SQLiteParameter("@updatedAt", annotation.UpdatedAt.ToString("yyyy-MM-dd-hh-mm-ss")); 
//			var pText = new SQLiteParameter("@text", annotation.Text);
//			var pCategoryId = new SQLiteParameter("@categoryId", annotation.CategoryId);
//			var pPosition = new SQLiteParameter("@position", annotation.Position); 
//			cmd.Parameters.Add(pId);
//			cmd.Parameters.Add(pTitle);
//			cmd.Parameters.Add(pCreatedAt);
//			cmd.Parameters.Add(pUdatedAt);
//			cmd.Parameters.Add(pText);
//			cmd.Parameters.Add(pCategoryId);
//			cmd.Parameters.Add(pPosition);
//			
//			cmd.ExecuteNonQuery();
		}

		public void insert(Category category)
		{
			var cmd = DBAccess.getCommand("select max(id) as id from category");
			var res = cmd.ExecuteScalar();
			var lastId = 1;
			if (res != DBNull.Value) {
				lastId = Convert.ToInt16(res) + 1;
			}
			category.Id = lastId;
			
			cmd = DBAccess.getCommand("insert into category (id, description, color, font, selected, mustHide, editable) values (@id, @description, @color, @font, @selected, @mustHide, @editable)");
			var pCodCateg = new SQLiteParameter("@id", category.Id);
			var pDesCateg = new SQLiteParameter("@description", category.Description);
			var pColor = new SQLiteParameter("@color", category.Color);
			var pFont = new SQLiteParameter("@font", category.Font); 
			var pSelected = new SQLiteParameter("@selected", category.Selected);
			var pMustHide = new SQLiteParameter("@mustHide", category.MustHide);
			var pEditable = new SQLiteParameter("@editable", category.Editable);
			cmd.Parameters.Add(pMustHide);
			cmd.Parameters.Add(pDesCateg);
			cmd.Parameters.Add(pColor);
			cmd.Parameters.Add(pFont);
			cmd.Parameters.Add(pSelected);
			cmd.Parameters.Add(pMustHide);
			cmd.Parameters.Add(pEditable);
			
			cmd.ExecuteNonQuery();
		}

		public void delete(int categoryId)
		{
			throw new NotImplementedException();
		}
		
		public bool select(int categoryId, bool select) {
			var cmd = DBAccess.getCommand("update category set selected = @selected where id = @id");
			var pId = new SQLiteParameter("@id", categoryId);
			var pSelected = new SQLiteParameter("@selected", select ? 1 : 0);
			cmd.Parameters.Add(pId);
			cmd.Parameters.Add(pSelected);
			
			return cmd.ExecuteNonQuery() > 0;
		}

		public Category buildObject(SQLiteDataReader res)
		{
			Category categ = new Category();
			categ.Id = res.GetInt16(res.GetOrdinal("id"));
			categ.Description = (string) res["description"];
			categ.Color = (string) res["color"];
			categ.Editable = (res["editable"] == DBNull.Value ? 0 : res.GetInt16(res.GetOrdinal("editable")));
			categ.Font = (res["font"] == DBNull.Value ? null : (string) res["font"]);
			categ.MustHide = (res["mustHide"] == DBNull.Value ? 0 : res.GetInt16(res.GetOrdinal("mustHide")));
			categ.Selected = res.GetInt16(res.GetOrdinal("selected"));
			
			return categ;
		}

		public Category get(int categoryId)
		{
			const string sql = "select id, description, color, font, selected, mustHide, editable from category where id = @id";
			SQLiteCommand cmd = DBAccess.getCommand(sql);
			try {
				Category category = null;

				SQLiteParameter pCodCateg = new SQLiteParameter("@id", categoryId);
				cmd.Parameters.Add(pCodCateg);
				SQLiteDataReader res = cmd.ExecuteReader(CommandBehavior.SequentialAccess);
				try {
					if (res.Read()) {
						category = buildObject(res);
					}
				} finally {
					res.Close();
				}
				       	
				return category;
			} catch (SqlException ex) {
				throw ex;
			}
		}

		public List<Category> listAll()
		{
			const string sql = "select id, description, color, font, selected, mustHide, editable from category";
			List<Category> list = new List<Category>();
			
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
		#endregion
	}
}
