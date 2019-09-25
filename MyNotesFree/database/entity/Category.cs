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
	public class Category
	{
		//Category code
		private int id;
		
		//Category Description
		private string description;
		
		//BG Color
		private String color;
		
		//FG Color
		private String font;
		
		//Selected category (for filter)
		private int selected;
		
		//Hidden category
		private int mustHide;
		
		//Category can be editable (for built in categories)
		private int editable;
	
		public int Id {
			get {
				return id;
			}
			set {
				id = value;
			}
		}

		public string Description {
			get {
				return description;
			}
			set {
				description = value;
			}
		}

		public String Color {
			get {
				return color;
			}
			set {
				color = value;
			}
		}

		public String Font {
			get {
				return font;
			}
			set {
				font = value;
			}
		}

		public int Selected {
			get {
				return selected;
			}
			set {
				selected = value;
			}
		}

		public int MustHide {
			get {
				return mustHide;
			}
			set {
				mustHide = value;
			}
		}

		public int Editable {
			get {
				return editable;
			}
			set {
				editable = value;
			}
		}
	}
}
