/*
 * Created by SharpDevelop.
 * User: roque.possamai
 * Date: 18/07/2019
 * Time: 18:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MyNotesFree.dao;

namespace MyNotesFree.dao
{
	/// <summary>
	/// Description of AnnotationDAO.
	/// </summary>
	public class AnnotationDAO: IAnnotationDAO
	{
		public AnnotationDAO()
		{
			
		}

		#region IAnnotationDAO implementation
		public void update(T annotation)
		{
			throw new NotImplementedException();
		}

		public void insert(T annotation)
		{
			throw new NotImplementedException();
		}

		public void delete(int codNote)
		{
			throw new NotImplementedException();
		}

		public Annotation get(int codNote)
		{
			throw new NotImplementedException();
		}

		public System.Collections.Generic.List<Annotation> listAll()
		{
			throw new NotImplementedException();
		}

		public System.Collections.Generic.List<Annotation> findInAnnotation(string textToSearch)
		{
			throw new NotImplementedException();
		}
		#endregion
	}
}
