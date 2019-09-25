/*
 * Created by SharpDevelop.
 * User: roque.possamai
 * Date: 23/07/2019
 */
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using MyNotesFree.database.delphi.entity;

namespace MyNotesFree.database.delphi.dao
{
	/// <summary>
	/// Description of CategoryDAO.
	/// </summary>
	public class DelphiCategoryDAO: IDelphiCategoryDAO
	{
		public DelphiCategoryDAO()
		{
		}

		#region ICategoryDAO implementation

		public void update(DelphiCategory category)
		{
			throw new NotImplementedException();
		}

		public void insert(DelphiCategory category)
		{
			throw new NotImplementedException();
		}

		public void delete(int categoryId)
		{
			throw new NotImplementedException();
		}

		public DelphiCategory buildObject(SQLiteDataReader res)
		{
			DelphiCategory categ = new DelphiCategory();
			categ.CodCateg = res.GetInt16(res.GetOrdinal("codCateg"));
			categ.DesCateg = (string) res["desCateg"];
			categ.CorCateg = (string) res["corCateg"];
			categ.EdtCateg = (res["edtCateg"] == DBNull.Value ? 0 : res.GetInt16(res.GetOrdinal("edtCateg")));
			categ.FntCateg = (res["fntCateg"] == DBNull.Value ? null : (string) res["fntCateg"]);
			categ.HidCateg = (res["hidCateg"] == DBNull.Value ? 0 : res.GetInt16(res.GetOrdinal("hidCateg")));
			categ.SelCateg = res.GetInt16(res.GetOrdinal("selCateg"));
			
			return categ;
		}

		public DelphiCategory get(int categoryId)
		{
			throw new NotImplementedException();
		}

		public List<DelphiCategory> listAll()
		{
			const string sql = "select CodCateg, DesCateg, corCateg, fntCateg, selCateg, hidCateg, edtCateg from categs";
			List<DelphiCategory> list = new List<DelphiCategory>();
			
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
