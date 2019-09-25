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
	/// Description of ConfigurationDAO.
	/// </summary>
	public class ConfigurationDAO: IConfigurationDAO
	{
		public ConfigurationDAO()
		{
		}

		#region IConfigurationDAO implementation

		public void update(Configuration category)
		{
			throw new NotImplementedException();
		}

		public void insert(Configuration category)
		{
			throw new NotImplementedException();
		}

		public void delete()
		{
			throw new NotImplementedException();
		}

		public Configuration buildObject(SQLiteDataReader res)
		{
			throw new NotImplementedException();
		}

		public Configuration get()
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
