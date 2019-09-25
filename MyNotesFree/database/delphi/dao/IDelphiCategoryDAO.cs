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
	/// Interface para o DAO de categorias.
	/// </summary>
	public interface IDelphiCategoryDAO
	{
		void update(DelphiCategory category);
		
		void insert(DelphiCategory category);

		void delete(int categoryId);
		
		DelphiCategory buildObject(SQLiteDataReader res);

		DelphiCategory get(int categoryId);
		
		List<DelphiCategory> listAll();
	}
}
