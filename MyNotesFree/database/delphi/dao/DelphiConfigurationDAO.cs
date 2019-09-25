/*
 * Created by SharpDevelop.
 * User: roque.possamai
 * Date: 23/07/2019
 */
using System;
using System.Data.SQLite;
using MyNotesFree.database.delphi.entity;

namespace MyNotesFree.database.delphi.dao
{
	/// <summary>
	/// Description of ConfigurationDAO.
	/// </summary>
	public class DelphiConfigurationDAO: IDelphiConfigurationDAO
	{
		public DelphiConfigurationDAO()
		{
		}

		#region IConfigurationDAO implementation

		public void update(DelphiConfiguration category)
		{
			throw new NotImplementedException();
		}

		public void insert(DelphiConfiguration category)
		{
			throw new NotImplementedException();
		}

		public void delete()
		{
			throw new NotImplementedException();
		}

		public DelphiConfiguration buildObject(SQLiteDataReader res)
		{
			throw new NotImplementedException();
		}

		public DelphiConfiguration get()
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
