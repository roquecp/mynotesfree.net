/*
 * Created by SharpDevelop.
 * User: roque.possamai
 * Date: 19/07/2019
 */
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using MyNotesFree.database.delphi.entity;

namespace MyNotesFree.database.delphi.dao
{
	/// <summary>
	/// Description of IAnnotation.
	/// </summary>
	public interface IDelphiAnnotationDAO
	{
		void update(DelphiAnnotation annotation);
		
		void insert(DelphiAnnotation annotation);

		void delete(int codNote);
		
		DelphiAnnotation buildObject(SQLiteDataReader res);

		DelphiAnnotation get(int codNote);
		
		DelphiAnnotation createNew(int categoryId);
		
		int getLastID();
		
		List<DelphiAnnotation> listAll();

		List<DelphiAnnotation> findInAnnotation(string textToSearch);
	}
}
