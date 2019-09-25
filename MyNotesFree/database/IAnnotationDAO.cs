/*
 * Created by SharpDevelop.
 * User: roque.possamai
 * Date: 19/07/2019
 * Time: 14:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace MyNotesFree.dao
{
	/// <summary>
	/// Description of IAnnotation.
	/// </summary>
	public interface IAnnotationDAO
	{
		void update(T annotation);
		
		void insert(T annotation);

		void delete(int codNote);

		Annotation get(int codNote);

		List<Annotation> listAll();

		List<Annotation> findInAnnotation(string textToSearch);
	}
}
