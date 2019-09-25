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
	/// Description of IConfigurationDAO.
	/// </summary>
	public interface IDelphiConfigurationDAO
	{
		void update(DelphiConfiguration category);
		
		void insert(DelphiConfiguration category);

		void delete();
		
		DelphiConfiguration buildObject(SQLiteDataReader res);

		DelphiConfiguration get();
	}
}
