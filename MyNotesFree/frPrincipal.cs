/*
 * Created by SharpDevelop.
 * User: Roque Possamai
 * Date: 15/07/2019
 */
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.Win32;
using MyNotesFree.component;
using MyNotesFree.database.dao;
using MyNotesFreeComponent;

namespace MyNotesFree
{
	/// <summary>
	/// Tela principal do MyNotesFree.Net
	/// </summary>
	public partial class frPrincipal: Form
	{
		private AnnotationDAO noteDao = new AnnotationDAO();
		private CategoryDAO categoryDao = new CategoryDAO();

		private bool populatingCategs = true; //True when updating Categories Listview (avoid event triggering)
		
		const string MORE_COLOR_NAME = "Mais...";

		int columnSort;

		int sortOrder;

		//Colors used on Font and Back color toolbar
		Color[] defaultColors = {
			Color.Aqua,			Color.Black,
			Color.LightBlue,	Color.Blue,
			Color.DarkBlue,		Color.Brown,
			Color.Cyan, 		Color.Gray,
			Color.Silver,		Color.Lime,
			Color.LightGreen,	Color.Green,
			Color.DarkGreen,  	Color.Navy,
			Color.Orange,		Color.Pink,
			Color.Purple,		Color.Magenta,
			Color.Red,			Color.DarkRed
		};
		
		Color currentBackColor;
		//Actual Selected Background Color
		Color currentForeColor;
		//Actual Selected Foregroung (font) color
		
		FormWindowState formState;
		NotifyIcon notifyIcon;

		private const String cStatusAnnotationRow = "Lin: {0} Col: {1}";
		private const string cStatusAnnotationCount = "Anotações: {0}";
		
		public frPrincipal()
		{
			InitializeComponent();
			
			if (!WinNoteApi.RegisterHotKey(this.Handle, 0, (int)WinNoteApi.KeyModifier.Alt + (int)WinNoteApi.KeyModifier.Control, Keys.N.GetHashCode())) {
				MessageBox.Show("Could not register CTRL + ALT + N hotkey! \n :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			notifyIcon = new NotifyIcon();
			
			notifyIcon.DoubleClick += NotificationIconClick;
			notifyIcon.Click += NotificationIconClick;
			var resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationIcon));
			notifyIcon.Icon = this.Icon;
			notifyIcon.Text = "MyNotesFree.net";
			notifyIcon.ContextMenuStrip = iconMenu;

			NotificationIcon notificationIcon = new NotificationIcon();
			notifyIcon.Visible = true;
			
			this.Text += Application.ProductVersion;

			populate_lvAnnotations();
			populate_Categories();
			
			populateToolbarValues();
			
			populateColorButtons();
			
			//TODO: Temporário
			lvAnnotations.Items[0].Selected = true;

			currentBackColor = reText.BackColor;
			currentForeColor = reText.ForeColor;
			
			LoadRegistryDefinitions();
		}

		void LoadRegistryDefinitions()
		{
			var key = Registry.CurrentUser.OpenSubKey("Software\\JellySoftware\\MyNotesFree.net");
			if (key != null) {
				this.Top = (int)key.GetValue("FormTop", this.Top);
				this.Left = (int)key.GetValue("FormLeft", this.Left);
				this.Width = (int)key.GetValue("FormWidth", this.Width);
				this.Height = (int)key.GetValue("FormHeight", this.Height);
				this.columnSort = (int)key.GetValue("ColumnSort", 2); //TODO: Data alteração
				this.sortOrder = (int)key.GetValue("SortOrder", 0); //desc
				this.splitAnnotationList.SplitterDistance = (int)key.GetValue("CategWidth", 500);
				this.splitPrincipal.SplitterDistance = (int)key.GetValue("GridHeight", 130);
	
				tbAutomaticIdent.Checked = (int)key.GetValue("AutoIndent", 0) == 1;
				tbLineBreak.Checked = (int)key.GetValue("LineBreak", 0) == 1;
			}
		}
		
		void SaveRegistryDefinitions() 
		{
			var key = Registry.CurrentUser.OpenSubKey("Software\\JellySoftware\\MyNotesFree.net", true);
			if (key == null) {
				key = Registry.CurrentUser.CreateSubKey("Software\\JellySoftware\\MyNotesFree.net");
			}
			if (key != null) {
				key.SetValue("FormTop", this.Top);
				key.SetValue("FormLeft", this.Left);
				key.SetValue("FormWidth", this.Width);
				key.SetValue("FormHeight", this.Height);
				key.SetValue("ColumnSort", 2); //TODO: Data alteração
				key.SetValue("SortOrder", 0); //desc
				key.SetValue("CategWidth", this.splitAnnotationList.SplitterDistance);
				key.SetValue("GridHeight", this.splitPrincipal.SplitterDistance);
	
				key.SetValue("AutoIndent", tbAutomaticIdent.Checked ? 1 : 0);
				key.SetValue("LineBreak", tbLineBreak.Checked ? 1 : 0);
			}
		}
		
		private void populateToolbarValues()
		{
			cbFontFace.Items.Clear();
			foreach (var fontFamily in FontFamily.Families) {
				cbFontFace.Items.Add(fontFamily.Name);
			}
		}
		
		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);
 
			if (m.Msg == 0x0312) {
				/* Note that the three lines below are not needed if you only want to register one hotkey.
                 * The below lines are useful in case you want to register multiple keys, which you can use a switch with the id as argument, or if you want to know which key/modifier was pressed for some particular reason. */
 
				Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);                  // The key of the hotkey that was pressed.
				WinNoteApi.KeyModifier modifier = (WinNoteApi.KeyModifier)((int)m.LParam & 0xFFFF);       // The modifier of the hotkey that was pressed.
				int id = m.WParam.ToInt32();                                        // The id of the hotkey that was pressed.
 
 
				NotificationIconClick(null, null);
				// do something
			}
		}

		//Controla a exibição do formulário através da tecla de atalho ou TrayIcon
		private void NotificationIconClick(object sender, EventArgs e)
		{
			if ((e == null) || ((e is MouseEventArgs) && ((MouseEventArgs)e).Button == MouseButtons.Left)) {
				IntPtr hand = WinNoteApi.GetForegroundWindow();
	
				iconMenuMinimizar.Text = "&Minimizar";
				Form form = Application.OpenForms["frPrincipal"];
				if (!form.Visible) {
					form.Visible = true;
					form.WindowState = formState;
					WinNoteApi.ForceForegroundWindow(form.Handle);
					reText.Focus();
				} else if (!form.Handle.Equals(hand) && sender == null) {
					WinNoteApi.ForceForegroundWindow(form.Handle);
					reText.Focus();
				} else {
					formState = form.WindowState;
					form.Visible = false;
					iconMenuMinimizar.Text = "&Restaurar";
				}
			}
		}
		
		void IconMenuMinimizarClick(object sender, EventArgs e)
		{
			NotificationIconClick(sender, null);
		}

		void FrPrincipalResize(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized) {
				NotificationIconClick(sender, null);
			}
		}
		
		void FrPrincipalFormClosed(object sender, FormClosedEventArgs e)
		{
			notifyIcon.Dispose();
			WinNoteApi.UnregisterHotKey(this.Handle, 0);
			SaveRegistryDefinitions();
		}
		
		//Encontra o componente selecionado (focused)
		public static Control FindFocusedControl(Control control)
		{
			var container = control as ContainerControl;
			return (null != container ? FindFocusedControl(container.ActiveControl) : control);
		}

		/*
		* Atualiza a Listview das anotações
 		*/
		void populate_lvAnnotations(int previousNote = -1)
		{
			previousNote = (previousNote == -1 ? (lvAnnotations.SelectedItems.Count > 0 ? (int)lvAnnotations.SelectedItems[0].Tag : -1) : previousNote);
			try {
				lvAnnotations.BeginUpdate();
				
				lvAnnotations.Items.Clear();
				var noteList = noteDao.listAllFiltered();
				foreach (var note in noteList) {
					var item = lvAnnotations.Items.Add(note.Title);
					item.Tag = note.Id;
					item.SubItems.Add(note.CreatedAt.ToString("dd/MM/yyyy hh:mm:ss"));
					item.SubItems.Add(note.UpdatedAt.ToString("dd/MM/yyyy hh:mm:ss"));
					item.SubItems.Add(note.Size.ToString());
					item.SubItems.Add(note.CategoryId.ToString());
					
					item.Selected = note.Id == previousNote;
					item.Focused = item.Selected;
					if (item.Selected)
						item.EnsureVisible();
				}
				statusAnnotationCount.Text = String.Format(cStatusAnnotationCount, noteList.Count);
				
			} finally {
				lvAnnotations.EndUpdate();
			}
		}
		
		/*
		* Atualiza a Listview e o combobox das Categorias
 		*/
		void populate_Categories()
		{
			populatingCategs = true;
			try {
				lvCategories.BeginUpdate();
				lvCategories.Items.Clear();
				var categories = categoryDao.listAll();
				
				foreach (var categ in categories) {
					var item = lvCategories.Items.Add(categ.Description);
					item.Tag = categ.Id;
					item.Checked = categ.Selected == 1;
					//TODO: Precisa converter a cor das categorias
					item.BackColor = Color.FromName(categ.Color);
					//Color.FromArgb(255, 255, 255); ???
				}
				//TODO: Implementar
			} finally {
				lvCategories.EndUpdate();
//				populatingCategs = false;
			}
				
		}
		void SairToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void ImportarArquivoToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK) {
				reText.LoadFile(openFileDialog.FileName);
			}
		}

		void LvAnnotationsItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			if (e.Item.Selected) {
				var note = noteDao.get((int)e.Item.Tag);
				reText.Rtf = note.Text;
				edTitle.Text = note.Title;
				reText.SelectionStart = note.Position;
				ReTextSelectionChanged(sender, null);
			}
			miAlterarCategoria.Enabled = e.Item.Selected;
			miExcluirAnotacao.Enabled = e.Item.Selected;
			alterarCategoriaToolStripMenuItem.Enabled = e.Item.Selected;
			statusAnnotationChanged.Text = "";
		}
		
		void SalvarAnotaçãoToolStripMenuItemClick(object sender, EventArgs e)
		{
			try {
				var note = noteDao.get((int)lvAnnotations.SelectedItems[0].Tag);
				note.Text = reText.Rtf;
				note.Title = edTitle.Text;
				note.UpdatedAt = DateTime.Now;
				note.Position = reText.SelectionStart;
				noteDao.update(note);
				
				populate_lvAnnotations();
			} catch (Exception ex) {
				MessageBox.Show("Erro salvando a anotação! " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 0, 0, false);
			}
		}

		void DesfazerToolStripMenuItemClick(object sender, EventArgs e)
		{
			var ctrl = FindFocusedControl(this.ActiveControl);
			if (ctrl is TextBoxBase) {
				((TextBoxBase)ctrl).Undo();
			}
		}

		void RefazerToolStripMenuItemClick(object sender, EventArgs e)
		{
			//Redo não funciona para TextBox :(
			var ctrl = FindFocusedControl(this.ActiveControl);
			if (ctrl is RichTextBox) {
				((RichTextBox)ctrl).Redo();
			}
		}

		void RecortarToolStripMenuItemClick(object sender, EventArgs e)
		{
			var ctrl = FindFocusedControl(this.ActiveControl);
			if (ctrl is TextBoxBase) {
				((TextBoxBase)ctrl).Cut();
			}
		}

		void CopiarToolStripMenuItemClick(object sender, EventArgs e)
		{
			var ctrl = FindFocusedControl(this.ActiveControl);
			if (ctrl is TextBoxBase) {
				((TextBoxBase)ctrl).Copy();
			}
		}

		void ColarToolStripMenuItemClick(object sender, EventArgs e)
		{
			var ctrl = FindFocusedControl(this.ActiveControl);
			if (ctrl is TextBoxBase) {
				((TextBoxBase)ctrl).Paste();
			}
		}

		void ColarEspecialToolStripMenuItemClick(object sender, EventArgs e)
		{
			//TODO Colar especial
		}

		void SelecionartudoToolStripMenuItemClick(object sender, EventArgs e)
		{
			var ctrl = FindFocusedControl(this.ActiveControl);
			if (ctrl is RichTextBox) {
				((RichTextBox)ctrl).SelectAll();
			}
		}

		void LocalizarToolStripMenuItemClick(object sender, EventArgs e)
		{
			//TODO: Find
		}

		void LocalizarProximoToolStripMenuItemClick(object sender, EventArgs e)
		{
			//TODO: FindNext
		}

		void LocalizarAnteriorToolStripMenuItemClick(object sender, EventArgs e)
		{
			//TODO: FindPrevious
		}

		void SubstituirToolStripMenuItemClick(object sender, EventArgs e)
		{
			//TODO: Replace
		}
		
		void ProcurarAnotacoesToolStripMenuItemClick(object sender, EventArgs e)
		{
			//TODO: Search
		}
		
		void NovaAnotacaoToolStripMenuItemClick(object sender, EventArgs e)
		{	
			var frCategoryList = new frCategoryList();
			if (frCategoryList.ShowDialog() == DialogResult.OK) {
				var note = noteDao.createNew(frCategoryList.CategoryId);
				populate_lvAnnotations(note.Id);
				edTitle.Select();
			}
		}
		
		void LvAnnotationsKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
				ExcluirAnotacaoToolStripMenuItemClick(sender, e);
		}
		
		void ExcluirAnotacaoToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (lvAnnotations.SelectedItems.Count > 0 &&
			    MessageBox.Show(String.Format("Deseja excluir a anotação \"{0}\"?", lvAnnotations.SelectedItems[0].SubItems[0].Text), "Atenção",
				    MessageBoxButtons.YesNo, MessageBoxIcon.Question, 
				    MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
				int noteId = (int)lvAnnotations.SelectedItems[0].Tag;
				noteDao.delete(noteId);
				populate_lvAnnotations(noteId);
			}
		}
		
		void TbBoldClick(object sender, EventArgs e)
		{
			var font = reText.SelectionFont;
			var style = (font.Bold ? font.Style & ~FontStyle.Bold : font.Style | FontStyle.Bold);
			reText.SelectionFont = new Font(reText.SelectionFont, style);
			ReTextSelectionChanged(null, null);
		}

		void TbItalicClick(object sender, EventArgs e)
		{
			var font = reText.SelectionFont;
			var style = (font.Italic ? font.Style & ~FontStyle.Italic : font.Style | FontStyle.Italic);
			reText.SelectionFont = new Font(reText.SelectionFont, style);
			ReTextSelectionChanged(null, null);
		}

		void TbUnderlineClick(object sender, EventArgs e)
		{
			var font = reText.SelectionFont;
			var style = (font.Underline ? font.Style & ~FontStyle.Underline : font.Style | FontStyle.Underline);
			reText.SelectionFont = new Font(reText.SelectionFont, style);
			ReTextSelectionChanged(null, null);
		}
		
		/**
		 * Atualiza todos os controles do formulário de acordo com a seleção
		 * do texto no RichTextEdit
		 **/   
		void ReTextSelectionChanged(object sender, EventArgs e)
		{
			tbBold.Checked = reText.SelectionFont.Bold;
			tbItalic.Checked = reText.SelectionFont.Italic;
			tbUnderline.Checked = reText.SelectionFont.Underline;
			tbAlignLeft.Checked = reText.SelectionAlignment == TextAlign.Left;
			tbAlignRight.Checked = reText.SelectionAlignment == TextAlign.Right;
			tbAlignCenter.Checked = reText.SelectionAlignment == TextAlign.Center;
			tbJustify.Checked = reText.SelectionAlignment == TextAlign.Justify;
			
			tbCopy.Enabled = reText.SelectionType != RichTextBoxSelectionTypes.Empty;
			tbPaste.Enabled = Clipboard.ContainsData(DataFormats.Text);
			tbCut.Enabled = tbCopy.Enabled;
			tbUndo.Enabled = reText.CanUndo;
			tbRedo.Enabled = reText.CanRedo;
			
			copiarToolStripMenuItem.Enabled = tbCopy.Enabled;
			colarEspecialToolStripMenuItem.Enabled = tbPaste.Enabled;
			recortarToolStripMenuItem.Enabled = tbCut.Enabled;
			desfazerToolStripMenuItem.Enabled = tbUndo.Enabled;
			refazerToolStripMenuItem.Enabled = tbRedo.Enabled;
			copyToolStripMenuItem.Enabled = tbCopy.Enabled;
			pasteToolStripMenuItem.Enabled = tbPaste.Enabled;
			cutToolStripMenuItem.Enabled = tbCut.Enabled;
			undoToolStripMenuItem.Enabled = tbUndo.Enabled;
			redoToolStripMenuItem.Enabled = tbRedo.Enabled;
			
			cbFontFace.SelectedIndex = cbFontFace.Items.IndexOf(reText.SelectionFont.FontFamily.Name);
			cbFontSize.Text = reText.SelectionFont.Size.ToString();
			
			int row = reText.GetLineFromCharIndex(reText.SelectionStart);
			int col = reText.SelectionStart - reText.GetFirstCharIndexFromLine(row);
			statusAnnotationRow.Text = String.Format(cStatusAnnotationRow, row + 1, col + 1);
//			statusAnnotationChanged.Text = reText.has
		}

		void TbAlignLeftClick(object sender, EventArgs e)
		{
			reText.SelectionAlignment = TextAlign.Left;
			ReTextSelectionChanged(null, null);
		}
		
		void TbAlignCenterClick(object sender, EventArgs e)
		{
			reText.SelectionAlignment = TextAlign.Center;
			ReTextSelectionChanged(null, null);
		}
		
		void TbAlignRightClick(object sender, EventArgs e)
		{
			reText.SelectionAlignment = TextAlign.Right;
			ReTextSelectionChanged(null, null);
		}
		
		void TbJustifyClick(object sender, EventArgs e)
		{
			reText.SelectionAlignment = TextAlign.Justify;
			ReTextSelectionChanged(null, null);
		}
		
		void ReTextLinkClicked(object sender, LinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(e.LinkText);
		}
		
		void TbFindClick(object sender, EventArgs e)
		{
			//TODO:
		}
		
		void StatusBarItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			//TODO: Usar?
		}
		
		void FrPrincipalKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape) {
				IconMenuMinimizarClick(sender, null);
			}
		}
		
		void CbFontFaceSelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbFontFace.SelectedIndex > -1) {
				reText.SelectionFont = new Font(cbFontFace.Text, reText.SelectionFont.Size, reText.SelectionFont.Style);
			}
		}
		
		void CbFontSizeSelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbFontSize.SelectedIndex > -1) {
				reText.SelectionFont = new Font(reText.SelectionFont.FontFamily, int.Parse(cbFontSize.Text), reText.SelectionFont.Style);
			}
		}
		
		private void populateColorButtons()
		{
			for (int i = 0; i < defaultColors.Length; i++) {
				var b = new Bitmap(20, 20);
				Graphics.FromImage(b).FillRectangle(new SolidBrush(Color.FromName(defaultColors[i].Name)), 0, 0, 20, 20);
				ssbFontColor.DropDownItems.Add(defaultColors[i].Name).Image = b;
				ssbBackColor.DropDownItems.Add(defaultColors[i].Name).Image = b;  
			}
			ssbFontColor.DropDownItems.Add("-");
			ssbFontColor.DropDownItems.Add(MORE_COLOR_NAME);
			ssbBackColor.DropDownItems.Add("-");
			ssbBackColor.DropDownItems.Add(MORE_COLOR_NAME);
		}
		
		void SsbFontColorDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			if (e.ClickedItem.Text.Equals(MORE_COLOR_NAME)) {
				ssbFontColor.HideDropDown();
				if (colorPicker.ShowDialog() == DialogResult.OK) {
					currentForeColor = colorPicker.Color;
				}
			} else {
				currentForeColor = Color.FromName(e.ClickedItem.Text);
			}
			ssbFontColor.Invalidate();
			SsbFontColorButtonClick(null, null);
		}

		void SsbBackColorDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			if (e.ClickedItem.Text.Equals(MORE_COLOR_NAME)) {
				ssbBackColor.HideDropDown();
			    if (colorPicker.ShowDialog() == DialogResult.OK) {
					currentBackColor = colorPicker.Color;
				}
			} else {
				currentBackColor = Color.FromName(e.ClickedItem.Text);	
			}
			ssbBackColor.Invalidate();
			SsbBackColorButtonClick(null, null);
		}

		void SsbFontColorPaint(object sender, PaintEventArgs e)
		{
			e.Graphics.FillRectangle(new SolidBrush(currentForeColor), new Rectangle(3, 3, ssbFontColor.Height - 6, ssbFontColor.Height - 6));
		}
		
		void SsbBackColorPaint(object sender, PaintEventArgs e)
		{
			e.Graphics.FillRectangle(new SolidBrush(currentBackColor), new Rectangle(3, 3, ssbBackColor.Height - 6, ssbBackColor.Height - 6));
		}
		
		void SsbFontColorButtonClick(object sender, EventArgs e)
		{
			reText.SelectionColor = currentForeColor;
		}
		
		void SsbBackColorButtonClick(object sender, EventArgs e)
		{
			reText.SelectionBackColor = currentBackColor;
		}
		
		void LvCategoriesItemChecked(object sender, ItemCheckedEventArgs e)
		{
			if (!populatingCategs) {
				categoryDao.select(int.Parse(e.Item.Tag.ToString()), e.Item.Checked);
				populate_lvAnnotations();
			}
		}
		
		void FrPrincipalShown(object sender, EventArgs e)
		{
			populatingCategs = false;
		}
		void MenuLvAnnotationsOpening(object sender, System.ComponentModel.CancelEventArgs e)
		{
	
		}
		
		void MiAlterarCategoriaClick(object sender, EventArgs e)
		{
			var frCategoryList = new frCategoryList();
			if (frCategoryList.ShowDialog() == DialogResult.OK) {
				var note = noteDao.get((int)lvAnnotations.SelectedItems[0].Tag);
				note.CategoryId = frCategoryList.CategoryId;
				noteDao.update(note);
				populate_lvAnnotations(note.Id);
			}
		}

		void ReTextTextChanged(object sender, EventArgs e)
		{
			statusAnnotationChanged.Text = "Alterado";
		}

		void LvAnnotationsDrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
		{
			e.DrawDefault = true;
		}
		
		void LvAnnotationsDrawSubItem(object sender, DrawListViewSubItemEventArgs e)
		{
	        e.DrawBackground();
            String text = (e.ColumnIndex == 0 ? e.Item.Text : e.SubItem.Text);

            if (e.Item.Selected)
	        {
	        	e.Graphics.FillRectangle(new SolidBrush(Color.Blue), e.Bounds);
	        	e.Graphics.DrawString(text, lvAnnotations.Font, new SolidBrush(Color.White), e.Bounds.X + 2, e.Bounds.Y);
	        } else {
	        	e.Graphics.DrawString(text, lvAnnotations.Font, new SolidBrush(Color.Black), e.Bounds.X + 2, e.Bounds.Y);
	        }
		}
		
		void BtnAddCategoryClick(object sender, EventArgs e)
		{
			var frCategory = new frCategory();
			if (frCategory.ShowDialog() == DialogResult.OK) {
				populate_Categories();
			}
			lvCategories.Focus();
		}

		void BtnEditCategoryClick(object sender, EventArgs e)
		{
			if (lvCategories.SelectedItems.Count > 0) {
				var category = categoryDao.get(int.Parse(lvCategories.SelectedItems[0].Tag.ToString()));
				var frCategory = new frCategory();
				frCategory.CategoryId = category.Id;
				if (frCategory.ShowDialog() == DialogResult.OK) {
					populate_Categories();
				}
			}
			lvCategories.Focus();
		}

		void BtnDelCategoryClick(object sender, EventArgs e)
		{
			populate_Categories();
			lvCategories.Focus();
		}
		
		void LvCategoriesItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			btnDelCategory.Enabled = e.IsSelected;
			btnEditCategory.Enabled = e.IsSelected;
		}

	}
}

