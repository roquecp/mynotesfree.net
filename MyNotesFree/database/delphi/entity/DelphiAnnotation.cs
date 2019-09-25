/*
 * Created by SharpDevelop.
 * User: roque.possamai
 * Date: 18/07/2019
 */
using System;

namespace MyNotesFree.database.delphi.entity
{
	/// <summary>
	/// Entidade que representa uma anotação
	/// </summary>
	public class DelphiAnnotation
	{
		//Annotation code
		private int codNote;
		
		//Annotation title
		private String titNote;
		
		//Annotation text
		private String texNote;
		
		//Created At
		private DateTime createdAt;
		
		//Updated At
		private DateTime updatedAt;
		
		//Category ID
		private int categoryId;
		
		//Password (Future use)
		private String password;
		
		public DelphiAnnotation()
		{
		}
		
		// disable all ConvertToAutoProperty
		public int CodNote {
			get {
				return codNote;
			}
			set {
				codNote = value;
			}
		}

		public String TitNote {
			get {
				return titNote;
			}
			set {
				titNote = value;
			}
		}

		public String TexNote {
			get {
				return texNote;
			}
			set {
				texNote = value;
			}
		}

		public DateTime CreatedAt {
			get {
				return createdAt;
			}
			set {
				createdAt = value;
			}
		}

		public DateTime UpdatedAt {
			get {
				return updatedAt;
			}
			set {
				updatedAt = value;
			}
		}

		public String Password {
			get {
				return password;
			}
			set {
				password = value;
			}
		}

		public int CategoryId {
			get {
				return categoryId;
			}
			set {
				categoryId = value;
			}
		}

		public int Size {
			get {
				return (texNote != null ? texNote.Length : 0);
			}
		}
	}
}
