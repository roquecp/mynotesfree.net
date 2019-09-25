/*
 * Created by SharpDevelop.
 * User: roque.possamai
 * Date: 23/07/2019
 * Time: 13:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace MyNotesFree.database.delphi.entity
{
	/// <summary>
	/// Configuration entity
	/// </summary>
	public class DelphiConfiguration
	{
		private String editorFont;
		private int editorFontSize;
		private String editorFontColor;
		private String editorFontStyle;
		private int minOnClose;
		private int startMinimized;
		private int updatePeriod;
		private DateTime nextUpdate;
		private int useProxy;
		private String proxyServer;
		private int proxyPort;
		private String proxyUser;
		private String proxyPass;
		private String shortcutMyNotes;
		private String shortcutQuickNotes;
		private int showCodCateg;
		
		public String EditorFont {
			get {
				return editorFont;
			}
			set {
				editorFont = value;
			}
		}

		public int EditorFontSize {
			get {
				return editorFontSize;
			}
			set {
				editorFontSize = value;
			}
		}

		public String EditorFontColor {
			get {
				return editorFontColor;
			}
			set {
				editorFontColor = value;
			}
		}

		public String EditorFontStyle {
			get {
				return editorFontStyle;
			}
			set {
				editorFontStyle = value;
			}
		}

		public int MinOnClose {
			get {
				return minOnClose;
			}
			set {
				minOnClose = value;
			}
		}

		public int StartMinimized {
			get {
				return startMinimized;
			}
			set {
				startMinimized = value;
			}
		}

		public int UpdatePeriod {
			get {
				return updatePeriod;
			}
			set {
				updatePeriod = value;
			}
		}

		public DateTime NextUpdate {
			get {
				return nextUpdate;
			}
			set {
				nextUpdate = value;
			}
		}

		public int UseProxy {
			get {
				return useProxy;
			}
			set {
				useProxy = value;
			}
		}

		public String ProxyServer {
			get {
				return proxyServer;
			}
			set {
				proxyServer = value;
			}
		}

		public int ProxyPort {
			get {
				return proxyPort;
			}
			set {
				proxyPort = value;
			}
		}

		public String ProxyUser {
			get {
				return proxyUser;
			}
			set {
				proxyUser = value;
			}
		}

		public String ProxyPass {
			get {
				return proxyPass;
			}
			set {
				proxyPass = value;
			}
		}

		public String ShortcutMyNotes {
			get {
				return shortcutMyNotes;
			}
			set {
				shortcutMyNotes = value;
			}
		}

		public String ShortcutQuickNotes {
			get {
				return shortcutQuickNotes;
			}
			set {
				shortcutQuickNotes = value;
			}
		}

		public int ShowCodCateg {
			get {
				return showCodCateg;
			}
			set {
				showCodCateg = value;
			}
		}
	}
}
