/*
 * Created by SharpDevelop.
 * User: roque.possamai
 * Date: 18/07/2019
 * Time: 18:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace MyNotesFree.dao
{
	/// <summary>
	/// Description of Annotation.
	/// </summary>
	public class Annotation
	{
		private int codNote;
		private String titNote;
		private String texNote;
		private DateTime datCriacao;
		private DateTime datAlteracao;
		private int codCateg;
		private String password;
		
		public Annotation()
		{
		}
		
		public int CodNote {
			get {
				return codNote;
			}
			set {
				codNote = value;
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

		public DateTime DatCriacao {
			get {
				return datCriacao;
			}
			set {
				datCriacao = value;
			}
		}

		public DateTime DatAlteracao {
			get {
				return datAlteracao;
			}
			set {
				datAlteracao = value;
			}
		}

		public int CodCateg {
			get {
				return codCateg;
			}
			set {
				codCateg = value;
			}
		}
	}
}
