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
	/// Interface para o DAO de categorias.
	/// </summary>
	public interface ICategoryDAO
	{
		void update(Category category);
		
		void insert(Category category);

		void delete(int categoryId);
		
		Category buildObject(SQLiteDataReader res);

		Category get(int categoryId);
		
		List<Category> listAll();
		
		bool select(int categoryId, bool select);
	}
}
