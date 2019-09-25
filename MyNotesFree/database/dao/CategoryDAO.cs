/*
 * Created by SharpDevelop.
 * User: roque.possamai
 * Date: 23/07/2019
 */
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using MyNotesFree.database.entity;

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
		}

		public void insert(Category category)
		{
			throw new NotImplementedException();
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
			throw new NotImplementedException();
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
