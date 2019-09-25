/*
 * Created by SharpDevelop.
 * User: roque.possamai
 * Date: 23/07/2019
 */
using System;
using System.Data.SQLite;
using MyNotesFree.database.entity;

namespace MyNotesFree.database.dao
{
	/// <summary>
	/// Description of IConfigurationDAO.
	/// </summary>
	public interface IConfigurationDAO
	{
		void update(Configuration category);
		
		void insert(Configuration category);

		void delete();
		
		Configuration buildObject(SQLiteDataReader res);

		Configuration get();
	}
}
