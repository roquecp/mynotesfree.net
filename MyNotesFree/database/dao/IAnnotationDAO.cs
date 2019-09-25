/*
 * Created by SharpDevelop.
 * User: roque.possamai
 * Date: 19/07/2019
 */
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using MyNotesFree.database.entity;

namespace MyNotesFree.database.dao
{
	/// <summary>
	/// Description of IAnnotation.
	/// </summary>
	public interface IAnnotationDAO
	{
		void update(Annotation annotation);
		
		void insert(Annotation annotation);

		void delete(int codNote);
		
		Annotation buildObject(SQLiteDataReader res);

		Annotation get(int id);
		
		Annotation createNew(int categoryId);
		
		int getLastID();
		
		List<Annotation> listAll();

		List<Annotation> listAllFiltered();

		List<Annotation> findInAnnotation(string textToSearch);
	}
}
