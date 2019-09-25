/*
 * Created by SharpDevelop.
 * User: roque.possamai
 * Date: 18/07/2019
 */
using System;

namespace MyNotesFree.database.entity
{
	/// <summary>
	/// Entidade que representa uma anotação
	/// </summary>
	public class Annotation
	{
		//Annotation code
		private int id;
		
		//Annotation title
		private String title;
		
		//Annotation text
		private String text;
		
		//Created At
		private DateTime createdAt;
		
		//Updated At
		private DateTime updatedAt;
		
		//Category ID
		private int categoryId;
		
		//Password (Future use)
		private String password;
		
		//Last cursor position in text
		private int position;
		
		//Text size
		private int size = -1;
		
		public Annotation()
		{
		}
		
		// disable all ConvertToAutoProperty
		public int Id {
			get {
				return id;
			}
			set {
				id = value;
			}
		}

		public String Title {
			get {
				return title;
			}
			set {
				title = value;
			}
		}

		public String Text {
			get {
				return text;
			}
			set {
				text = value;
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
				return (size > -1 ? size : (text != null ? text.Length : 0));
			}
			set {
				size = value;
			}
		}

		public int Position {
			get {
				return position;
			}
			set {
				position = value;
			}
		}

	}
}
