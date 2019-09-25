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
	public class DelphiCategory
	{
		//Category code
		private int codCateg;
		
		//Category Description
		private string desCateg;
		
		//BG Color
		private String corCateg;
		
		//FG Color
		private String fntCateg;
		
		//Selected category (for filter)
		private int selCateg;
		
		//Hidden category
		private int hidCateg;
		
		//Category can be editable (for built in categories)
		private int edtCateg;
	
		public int CodCateg {
			get {
				return codCateg;
			}
			set {
				codCateg = value;
			}
		}

		public string DesCateg {
			get {
				return desCateg;
			}
			set {
				desCateg = value;
			}
		}

		public String CorCateg {
			get {
				return corCateg;
			}
			set {
				corCateg = value;
			}
		}

		public String FntCateg {
			get {
				return fntCateg;
			}
			set {
				fntCateg = value;
			}
		}

		public int SelCateg {
			get {
				return selCateg;
			}
			set {
				selCateg = value;
			}
		}

		public int HidCateg {
			get {
				return hidCateg;
			}
			set {
				hidCateg = value;
			}
		}

		public int EdtCateg {
			get {
				return edtCateg;
			}
			set {
				edtCateg = value;
			}
		}
	}
}
