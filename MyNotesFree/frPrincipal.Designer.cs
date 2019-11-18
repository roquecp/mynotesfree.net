/*
 * Created by SharpDevelop.
 * User: roque.possamai
 * Date: 15/07/2019
 */
namespace MyNotesFree
{
	partial class frPrincipal
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ToolStrip toolBar;
		private System.Windows.Forms.MenuStrip menuPrincipal;
		private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem novaAnotacaoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salvarAnotacaoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem excluirAnotacaoToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem formatarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton tbCopy;
		private System.Windows.Forms.SplitContainer splitAnnotationList;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox edTitle;
		private System.Windows.Forms.Label label1;
		private MyNotesFreeComponent.AdvRichTextBox reText;
		private System.Windows.Forms.ListView lvAnnotations;
		private System.Windows.Forms.ColumnHeader chTitle;
		private System.Windows.Forms.ColumnHeader chCreationDate;
		private System.Windows.Forms.ColumnHeader chModifyDate;
		private System.Windows.Forms.ColumnHeader chSize;
		private System.Windows.Forms.ColumnHeader chCategory;
		private System.Windows.Forms.ListView lvCategories;
		private System.Windows.Forms.ToolStripMenuItem importarArquivoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportarAnotacaoToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.ToolStripMenuItem visualizarImpressaoToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem desfazerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem refazerToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem recortarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem colarEspecialToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem selecionartudoToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem localizarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem localizarProximoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem localizarAnteriorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem substituirToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem procurarAnotacoesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem barraDestatusToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem barraDeferramentasToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
		private System.Windows.Forms.ToolStripMenuItem irParaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem contarPalavrasToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
		private System.Windows.Forms.ToolStripMenuItem quickNoteToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton tbSave;
		private System.Windows.Forms.ToolStripButton tbNew;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton tbCut;
		private System.Windows.Forms.ToolStripButton tbPaste;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
		private System.Windows.Forms.ToolStripButton tbUndo;
		private System.Windows.Forms.ToolStripButton tbRedo;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
		private System.Windows.Forms.ToolStripButton tbAlignLeft;
		private System.Windows.Forms.ToolStripButton tbAlignCenter;
		private System.Windows.Forms.ToolStripButton tbAlignRight;
		private System.Windows.Forms.ToolStripButton tbJustify;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton tbBold;
		private System.Windows.Forms.ToolStripButton tbItalic;
		private System.Windows.Forms.ToolStripButton tbUnderline;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton tbUnorderedList;
		private System.Windows.Forms.ToolStripButton tbOrderedList;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton tbSubScript;
		private System.Windows.Forms.ToolStripButton tbSuperScript;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripComboBox cbFontFace;
		private System.Windows.Forms.ToolStripComboBox cbFontSize;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripComboBox cbZoom;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripButton tbFind;
		private System.Windows.Forms.ToolStripButton tbReplace;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
		private System.Windows.Forms.ToolStripButton tbAutomaticIdent;
		private System.Windows.Forms.ToolStripButton tbLineBreak;
		private System.Windows.Forms.ContextMenuStrip menuEditor;
		private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
		private System.Windows.Forms.ToolStripMenuItem toUpperToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toLowerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem paragraphToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem negritoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem italicoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sublinhadoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
		private System.Windows.Forms.ContextMenuStrip iconMenu;
		private System.Windows.Forms.ToolStripMenuItem iconMenuMinimizar;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem12;
		private System.Windows.Forms.ToolStripMenuItem iconMenuSair;
		private System.Windows.Forms.ToolStripStatusLabel statusMsg;
		private System.Windows.Forms.ToolStripProgressBar statusUpdateToolbar;
		private System.Windows.Forms.ToolStripStatusLabel statusAnnotationCount;
		private System.Windows.Forms.ToolStripStatusLabel statusAnnotationChanged;
		private System.Windows.Forms.ToolStripStatusLabel statusAnnotationRow;
		private System.Windows.Forms.ToolStripSplitButton ssbFontColor;
		private System.Windows.Forms.ToolStripSplitButton ssbBackColor;
		private System.Windows.Forms.ColorDialog colorPicker;
		private System.Windows.Forms.ContextMenuStrip menuLvAnnotations;
		private System.Windows.Forms.ToolStripMenuItem miNovaAnotacao;
		private System.Windows.Forms.ToolStripMenuItem miExcluirAnotacao;
		private System.Windows.Forms.ToolStripMenuItem miAlterarCategoria;
		private System.Windows.Forms.ToolStripMenuItem alterarCategoriaToolStripMenuItem;
		private System.Windows.Forms.SplitContainer splitPrincipal;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frPrincipal));
			this.splitAnnotationList = new System.Windows.Forms.SplitContainer();
			this.lvAnnotations = new System.Windows.Forms.ListView();
			this.chTitle = new System.Windows.Forms.ColumnHeader();
			this.chCreationDate = new System.Windows.Forms.ColumnHeader();
			this.chModifyDate = new System.Windows.Forms.ColumnHeader();
			this.chSize = new System.Windows.Forms.ColumnHeader();
			this.chCategory = new System.Windows.Forms.ColumnHeader();
			this.menuLvAnnotations = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.miNovaAnotacao = new System.Windows.Forms.ToolStripMenuItem();
			this.miExcluirAnotacao = new System.Windows.Forms.ToolStripMenuItem();
			this.miAlterarCategoria = new System.Windows.Forms.ToolStripMenuItem();
			this.lvCategories = new System.Windows.Forms.ListView();
			this.reText = new MyNotesFreeComponent.AdvRichTextBox();
			this.menuEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
			this.toUpperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toLowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.paragraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
			this.negritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.italicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sublinhadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusBar = new System.Windows.Forms.StatusStrip();
			this.statusMsg = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusUpdateToolbar = new System.Windows.Forms.ToolStripProgressBar();
			this.statusAnnotationCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusAnnotationChanged = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusAnnotationRow = new System.Windows.Forms.ToolStripStatusLabel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.edTitle = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.toolBar = new System.Windows.Forms.ToolStrip();
			this.tbSave = new System.Windows.Forms.ToolStripButton();
			this.tbNew = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tbCopy = new System.Windows.Forms.ToolStripButton();
			this.tbCut = new System.Windows.Forms.ToolStripButton();
			this.tbPaste = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this.tbUndo = new System.Windows.Forms.ToolStripButton();
			this.tbRedo = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
			this.tbAlignLeft = new System.Windows.Forms.ToolStripButton();
			this.tbAlignCenter = new System.Windows.Forms.ToolStripButton();
			this.tbAlignRight = new System.Windows.Forms.ToolStripButton();
			this.tbJustify = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tbBold = new System.Windows.Forms.ToolStripButton();
			this.tbItalic = new System.Windows.Forms.ToolStripButton();
			this.tbUnderline = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.tbUnorderedList = new System.Windows.Forms.ToolStripButton();
			this.tbOrderedList = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.tbSubScript = new System.Windows.Forms.ToolStripButton();
			this.tbSuperScript = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.cbFontFace = new System.Windows.Forms.ToolStripComboBox();
			this.cbFontSize = new System.Windows.Forms.ToolStripComboBox();
			this.ssbFontColor = new System.Windows.Forms.ToolStripSplitButton();
			this.ssbBackColor = new System.Windows.Forms.ToolStripSplitButton();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.cbZoom = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.tbFind = new System.Windows.Forms.ToolStripButton();
			this.tbReplace = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
			this.tbAutomaticIdent = new System.Windows.Forms.ToolStripButton();
			this.tbLineBreak = new System.Windows.Forms.ToolStripButton();
			this.menuPrincipal = new System.Windows.Forms.MenuStrip();
			this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.novaAnotacaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salvarAnotacaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.excluirAnotacaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.importarArquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportarAnotacaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.visualizarImpressaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.desfazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.refazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			this.recortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.colarEspecialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selecionartudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
			this.localizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.localizarProximoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.localizarAnteriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.substituirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
			this.procurarAnotacoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alterarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.barraDestatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.barraDeferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
			this.irParaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contarPalavrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
			this.quickNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inserirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.formatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.iconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.iconMenuMinimizar = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripSeparator();
			this.iconMenuSair = new System.Windows.Forms.ToolStripMenuItem();
			this.colorPicker = new System.Windows.Forms.ColorDialog();
			this.splitPrincipal = new System.Windows.Forms.SplitContainer();
			((System.ComponentModel.ISupportInitialize)(this.splitAnnotationList)).BeginInit();
			this.splitAnnotationList.Panel1.SuspendLayout();
			this.splitAnnotationList.Panel2.SuspendLayout();
			this.splitAnnotationList.SuspendLayout();
			this.menuLvAnnotations.SuspendLayout();
			this.menuEditor.SuspendLayout();
			this.statusBar.SuspendLayout();
			this.panel1.SuspendLayout();
			this.toolBar.SuspendLayout();
			this.menuPrincipal.SuspendLayout();
			this.iconMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitPrincipal)).BeginInit();
			this.splitPrincipal.Panel1.SuspendLayout();
			this.splitPrincipal.Panel2.SuspendLayout();
			this.splitPrincipal.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitAnnotationList
			// 
			this.splitAnnotationList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitAnnotationList.Location = new System.Drawing.Point(0, 0);
			this.splitAnnotationList.Name = "splitAnnotationList";
			// 
			// splitAnnotationList.Panel1
			// 
			this.splitAnnotationList.Panel1.Controls.Add(this.lvAnnotations);
			this.splitAnnotationList.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			// 
			// splitAnnotationList.Panel2
			// 
			this.splitAnnotationList.Panel2.Controls.Add(this.lvCategories);
			this.splitAnnotationList.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.splitAnnotationList.Size = new System.Drawing.Size(1073, 130);
			this.splitAnnotationList.SplitterDistance = 720;
			this.splitAnnotationList.TabIndex = 0;
			this.splitAnnotationList.TabStop = false;
			// 
			// lvAnnotations
			// 
			this.lvAnnotations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.chTitle,
			this.chCreationDate,
			this.chModifyDate,
			this.chSize,
			this.chCategory});
			this.lvAnnotations.ContextMenuStrip = this.menuLvAnnotations;
			this.lvAnnotations.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvAnnotations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lvAnnotations.FullRowSelect = true;
			this.lvAnnotations.GridLines = true;
			this.lvAnnotations.HideSelection = false;
			this.lvAnnotations.LabelWrap = false;
			this.lvAnnotations.Location = new System.Drawing.Point(0, 0);
			this.lvAnnotations.MultiSelect = false;
			this.lvAnnotations.Name = "lvAnnotations";
			this.lvAnnotations.OwnerDraw = true;
			this.lvAnnotations.Size = new System.Drawing.Size(720, 130);
			this.lvAnnotations.TabIndex = 0;
			this.lvAnnotations.UseCompatibleStateImageBehavior = false;
			this.lvAnnotations.View = System.Windows.Forms.View.Details;
			this.lvAnnotations.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.LvAnnotationsDrawColumnHeader);
			this.lvAnnotations.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.LvAnnotationsDrawSubItem);
			this.lvAnnotations.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LvAnnotationsItemSelectionChanged);
			this.lvAnnotations.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LvAnnotationsKeyDown);
			// 
			// chTitle
			// 
			this.chTitle.Text = "Título";
			this.chTitle.Width = 200;
			// 
			// chCreationDate
			// 
			this.chCreationDate.Text = "Data de criação";
			this.chCreationDate.Width = 120;
			// 
			// chModifyDate
			// 
			this.chModifyDate.Text = "Data de alteração";
			this.chModifyDate.Width = 120;
			// 
			// chSize
			// 
			this.chSize.Text = "Tamanho";
			this.chSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.chSize.Width = 65;
			// 
			// chCategory
			// 
			this.chCategory.Text = "Categoria";
			this.chCategory.Width = 120;
			// 
			// menuLvAnnotations
			// 
			this.menuLvAnnotations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.miNovaAnotacao,
			this.miExcluirAnotacao,
			this.miAlterarCategoria});
			this.menuLvAnnotations.Name = "menuLvAnnotations";
			this.menuLvAnnotations.Size = new System.Drawing.Size(171, 70);
			// 
			// miNovaAnotacao
			// 
			this.miNovaAnotacao.Name = "miNovaAnotacao";
			this.miNovaAnotacao.Size = new System.Drawing.Size(170, 22);
			this.miNovaAnotacao.Text = "&Nova anotação...";
			this.miNovaAnotacao.Click += new System.EventHandler(this.NovaAnotacaoToolStripMenuItemClick);
			// 
			// miExcluirAnotacao
			// 
			this.miExcluirAnotacao.Name = "miExcluirAnotacao";
			this.miExcluirAnotacao.Size = new System.Drawing.Size(170, 22);
			this.miExcluirAnotacao.Text = "&Excluir anotação...";
			this.miExcluirAnotacao.Click += new System.EventHandler(this.ExcluirAnotacaoToolStripMenuItemClick);
			// 
			// miAlterarCategoria
			// 
			this.miAlterarCategoria.Name = "miAlterarCategoria";
			this.miAlterarCategoria.Size = new System.Drawing.Size(170, 22);
			this.miAlterarCategoria.Text = "Alterar &categoria...";
			this.miAlterarCategoria.Click += new System.EventHandler(this.MiAlterarCategoriaClick);
			// 
			// lvCategories
			// 
			this.lvCategories.CheckBoxes = true;
			this.lvCategories.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvCategories.Location = new System.Drawing.Point(0, 0);
			this.lvCategories.MultiSelect = false;
			this.lvCategories.Name = "lvCategories";
			this.lvCategories.Size = new System.Drawing.Size(349, 130);
			this.lvCategories.TabIndex = 0;
			this.lvCategories.UseCompatibleStateImageBehavior = false;
			this.lvCategories.View = System.Windows.Forms.View.List;
			this.lvCategories.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.LvCategoriesItemChecked);
			// 
			// reText
			// 
			this.reText.ContextMenuStrip = this.menuEditor;
			this.reText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.reText.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.reText.HideSelection = false;
			this.reText.Location = new System.Drawing.Point(0, 31);
			this.reText.Name = "reText";
			this.reText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
			this.reText.SelectionAlignment = MyNotesFreeComponent.TextAlign.Left;
			this.reText.Size = new System.Drawing.Size(1073, 246);
			this.reText.TabIndex = 3;
			this.reText.Text = "";
			this.reText.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.ReTextLinkClicked);
			this.reText.SelectionChanged += new System.EventHandler(this.ReTextSelectionChanged);
			this.reText.TextChanged += new System.EventHandler(this.ReTextTextChanged);
			// 
			// menuEditor
			// 
			this.menuEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.undoToolStripMenuItem,
			this.redoToolStripMenuItem,
			this.toolStripMenuItem9,
			this.copyToolStripMenuItem,
			this.pasteToolStripMenuItem,
			this.cutToolStripMenuItem,
			this.toolStripMenuItem10,
			this.toUpperToolStripMenuItem,
			this.toLowerToolStripMenuItem,
			this.paragraphToolStripMenuItem,
			this.showToolStripMenuItem,
			this.toolStripMenuItem11,
			this.negritoToolStripMenuItem,
			this.italicoToolStripMenuItem,
			this.sublinhadoToolStripMenuItem});
			this.menuEditor.Name = "menuEditor";
			this.menuEditor.Size = new System.Drawing.Size(177, 302);
			// 
			// undoToolStripMenuItem
			// 
			this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
			this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.undoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.undoToolStripMenuItem.Text = "Desfa&zer";
			this.undoToolStripMenuItem.Click += new System.EventHandler(this.DesfazerToolStripMenuItemClick);
			// 
			// redoToolStripMenuItem
			// 
			this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
			this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
			this.redoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.redoToolStripMenuItem.Text = "&Refazer";
			this.redoToolStripMenuItem.Click += new System.EventHandler(this.RefazerToolStripMenuItemClick);
			// 
			// toolStripMenuItem9
			// 
			this.toolStripMenuItem9.Name = "toolStripMenuItem9";
			this.toolStripMenuItem9.Size = new System.Drawing.Size(173, 6);
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.copyToolStripMenuItem.Text = "&Copiar";
			this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopiarToolStripMenuItemClick);
			// 
			// pasteToolStripMenuItem
			// 
			this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.pasteToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.pasteToolStripMenuItem.Text = "C&olar";
			this.pasteToolStripMenuItem.Click += new System.EventHandler(this.ColarToolStripMenuItemClick);
			// 
			// cutToolStripMenuItem
			// 
			this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
			this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.cutToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.cutToolStripMenuItem.Text = "R&ecortar";
			this.cutToolStripMenuItem.Click += new System.EventHandler(this.RecortarToolStripMenuItemClick);
			// 
			// toolStripMenuItem10
			// 
			this.toolStripMenuItem10.Name = "toolStripMenuItem10";
			this.toolStripMenuItem10.Size = new System.Drawing.Size(173, 6);
			// 
			// toUpperToolStripMenuItem
			// 
			this.toUpperToolStripMenuItem.Name = "toUpperToolStripMenuItem";
			this.toUpperToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.toUpperToolStripMenuItem.Text = "&Para maiúsculas";
			// 
			// toLowerToolStripMenuItem
			// 
			this.toLowerToolStripMenuItem.Name = "toLowerToolStripMenuItem";
			this.toLowerToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.toLowerToolStripMenuItem.Text = "Para &minúsculas";
			// 
			// paragraphToolStripMenuItem
			// 
			this.paragraphToolStripMenuItem.Name = "paragraphToolStripMenuItem";
			this.paragraphToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.paragraphToolStripMenuItem.Text = "Parágra&fo...";
			// 
			// showToolStripMenuItem
			// 
			this.showToolStripMenuItem.Name = "showToolStripMenuItem";
			this.showToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.showToolStripMenuItem.Text = "E&xibir";
			// 
			// toolStripMenuItem11
			// 
			this.toolStripMenuItem11.Name = "toolStripMenuItem11";
			this.toolStripMenuItem11.Size = new System.Drawing.Size(176, 22);
			this.toolStripMenuItem11.Text = "--- ocultos ---";
			this.toolStripMenuItem11.Visible = false;
			// 
			// negritoToolStripMenuItem
			// 
			this.negritoToolStripMenuItem.Name = "negritoToolStripMenuItem";
			this.negritoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.negritoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.negritoToolStripMenuItem.Text = "Negrito";
			this.negritoToolStripMenuItem.Visible = false;
			this.negritoToolStripMenuItem.Click += new System.EventHandler(this.TbBoldClick);
			// 
			// italicoToolStripMenuItem
			// 
			this.italicoToolStripMenuItem.Name = "italicoToolStripMenuItem";
			this.italicoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
			this.italicoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.italicoToolStripMenuItem.Text = "Italico";
			this.italicoToolStripMenuItem.Visible = false;
			this.italicoToolStripMenuItem.Click += new System.EventHandler(this.TbItalicClick);
			// 
			// sublinhadoToolStripMenuItem
			// 
			this.sublinhadoToolStripMenuItem.Name = "sublinhadoToolStripMenuItem";
			this.sublinhadoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
			this.sublinhadoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.sublinhadoToolStripMenuItem.Text = "Sublinhado";
			this.sublinhadoToolStripMenuItem.Visible = false;
			this.sublinhadoToolStripMenuItem.Click += new System.EventHandler(this.TbUnderlineClick);
			// 
			// statusBar
			// 
			this.statusBar.GripMargin = new System.Windows.Forms.Padding(1);
			this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.statusMsg,
			this.statusUpdateToolbar,
			this.statusAnnotationCount,
			this.statusAnnotationChanged,
			this.statusAnnotationRow});
			this.statusBar.Location = new System.Drawing.Point(0, 277);
			this.statusBar.Name = "statusBar";
			this.statusBar.Size = new System.Drawing.Size(1073, 25);
			this.statusBar.TabIndex = 2;
			// 
			// statusMsg
			// 
			this.statusMsg.AutoSize = false;
			this.statusMsg.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
			| System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
			| System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.statusMsg.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
			this.statusMsg.Name = "statusMsg";
			this.statusMsg.Size = new System.Drawing.Size(716, 20);
			this.statusMsg.Spring = true;
			// 
			// statusUpdateToolbar
			// 
			this.statusUpdateToolbar.AutoSize = false;
			this.statusUpdateToolbar.Enabled = false;
			this.statusUpdateToolbar.Name = "statusUpdateToolbar";
			this.statusUpdateToolbar.Size = new System.Drawing.Size(100, 19);
			// 
			// statusAnnotationCount
			// 
			this.statusAnnotationCount.AutoSize = false;
			this.statusAnnotationCount.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
			| System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
			| System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.statusAnnotationCount.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
			this.statusAnnotationCount.Name = "statusAnnotationCount";
			this.statusAnnotationCount.Size = new System.Drawing.Size(100, 20);
			this.statusAnnotationCount.Text = "Anotações: 999";
			// 
			// statusAnnotationChanged
			// 
			this.statusAnnotationChanged.AutoSize = false;
			this.statusAnnotationChanged.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
			| System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
			| System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.statusAnnotationChanged.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
			this.statusAnnotationChanged.Name = "statusAnnotationChanged";
			this.statusAnnotationChanged.Size = new System.Drawing.Size(50, 20);
			this.statusAnnotationChanged.Text = "Alterado";
			// 
			// statusAnnotationRow
			// 
			this.statusAnnotationRow.AutoSize = false;
			this.statusAnnotationRow.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
			| System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
			| System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.statusAnnotationRow.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
			this.statusAnnotationRow.Name = "statusAnnotationRow";
			this.statusAnnotationRow.Size = new System.Drawing.Size(90, 20);
			this.statusAnnotationRow.Text = "Lin:     1 Col:     1";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.edTitle);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1073, 31);
			this.panel1.TabIndex = 1;
			// 
			// edTitle
			// 
			this.edTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.edTitle.Location = new System.Drawing.Point(43, 5);
			this.edTitle.Name = "edTitle";
			this.edTitle.Size = new System.Drawing.Size(1014, 20);
			this.edTitle.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(5, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Título:";
			// 
			// toolBar
			// 
			this.toolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tbSave,
			this.tbNew,
			this.toolStripSeparator1,
			this.tbCopy,
			this.tbCut,
			this.tbPaste,
			this.toolStripSeparator8,
			this.tbUndo,
			this.tbRedo,
			this.toolStripSeparator9,
			this.tbAlignLeft,
			this.tbAlignCenter,
			this.tbAlignRight,
			this.tbJustify,
			this.toolStripSeparator2,
			this.tbBold,
			this.tbItalic,
			this.tbUnderline,
			this.toolStripSeparator3,
			this.tbUnorderedList,
			this.tbOrderedList,
			this.toolStripSeparator4,
			this.tbSubScript,
			this.tbSuperScript,
			this.toolStripSeparator5,
			this.cbFontFace,
			this.cbFontSize,
			this.ssbFontColor,
			this.ssbBackColor,
			this.toolStripSeparator6,
			this.cbZoom,
			this.toolStripSeparator7,
			this.tbFind,
			this.tbReplace,
			this.toolStripSeparator10,
			this.tbAutomaticIdent,
			this.tbLineBreak});
			this.toolBar.Location = new System.Drawing.Point(2, 26);
			this.toolBar.Name = "toolBar";
			this.toolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.toolBar.Size = new System.Drawing.Size(1073, 25);
			this.toolBar.TabIndex = 1;
			this.toolBar.Text = "toolStrip1";
			// 
			// tbSave
			// 
			this.tbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbSave.Image = ((System.Drawing.Image)(resources.GetObject("tbSave.Image")));
			this.tbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbSave.Name = "tbSave";
			this.tbSave.Size = new System.Drawing.Size(23, 22);
			this.tbSave.Text = "toolStripButton2";
			this.tbSave.ToolTipText = "Salvar anotação";
			this.tbSave.Click += new System.EventHandler(this.SalvarAnotaçãoToolStripMenuItemClick);
			// 
			// tbNew
			// 
			this.tbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbNew.Image = ((System.Drawing.Image)(resources.GetObject("tbNew.Image")));
			this.tbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbNew.Name = "tbNew";
			this.tbNew.Size = new System.Drawing.Size(23, 22);
			this.tbNew.Text = "toolStripButton1";
			this.tbNew.ToolTipText = "Nova anotação";
			this.tbNew.Click += new System.EventHandler(this.NovaAnotacaoToolStripMenuItemClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// tbCopy
			// 
			this.tbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbCopy.Image = ((System.Drawing.Image)(resources.GetObject("tbCopy.Image")));
			this.tbCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbCopy.Name = "tbCopy";
			this.tbCopy.Size = new System.Drawing.Size(23, 22);
			this.tbCopy.ToolTipText = "Copiar";
			this.tbCopy.Click += new System.EventHandler(this.CopiarToolStripMenuItemClick);
			// 
			// tbCut
			// 
			this.tbCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbCut.Image = ((System.Drawing.Image)(resources.GetObject("tbCut.Image")));
			this.tbCut.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbCut.Name = "tbCut";
			this.tbCut.Size = new System.Drawing.Size(23, 22);
			this.tbCut.Text = "C&ut";
			this.tbCut.ToolTipText = "Recortar";
			this.tbCut.Click += new System.EventHandler(this.RecortarToolStripMenuItemClick);
			// 
			// tbPaste
			// 
			this.tbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbPaste.Image = ((System.Drawing.Image)(resources.GetObject("tbPaste.Image")));
			this.tbPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbPaste.Name = "tbPaste";
			this.tbPaste.Size = new System.Drawing.Size(23, 22);
			this.tbPaste.Text = "toolStripButton13";
			this.tbPaste.ToolTipText = "Colar";
			this.tbPaste.Click += new System.EventHandler(this.ColarToolStripMenuItemClick);
			// 
			// toolStripSeparator8
			// 
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
			// 
			// tbUndo
			// 
			this.tbUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbUndo.Image = ((System.Drawing.Image)(resources.GetObject("tbUndo.Image")));
			this.tbUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbUndo.Name = "tbUndo";
			this.tbUndo.Size = new System.Drawing.Size(23, 22);
			this.tbUndo.Text = "toolStripButton12";
			this.tbUndo.ToolTipText = "Desfazer";
			this.tbUndo.Click += new System.EventHandler(this.DesfazerToolStripMenuItemClick);
			// 
			// tbRedo
			// 
			this.tbRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbRedo.Image = ((System.Drawing.Image)(resources.GetObject("tbRedo.Image")));
			this.tbRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbRedo.Name = "tbRedo";
			this.tbRedo.Size = new System.Drawing.Size(23, 22);
			this.tbRedo.Text = "toolStripButton13";
			this.tbRedo.ToolTipText = "Refazer";
			this.tbRedo.Click += new System.EventHandler(this.RefazerToolStripMenuItemClick);
			// 
			// toolStripSeparator9
			// 
			this.toolStripSeparator9.Name = "toolStripSeparator9";
			this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
			// 
			// tbAlignLeft
			// 
			this.tbAlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbAlignLeft.Image = ((System.Drawing.Image)(resources.GetObject("tbAlignLeft.Image")));
			this.tbAlignLeft.ImageTransparentColor = System.Drawing.Color.White;
			this.tbAlignLeft.Name = "tbAlignLeft";
			this.tbAlignLeft.Size = new System.Drawing.Size(23, 22);
			this.tbAlignLeft.Text = "toolStripButton1";
			this.tbAlignLeft.ToolTipText = "Alinhar à esquerda";
			this.tbAlignLeft.Click += new System.EventHandler(this.TbAlignLeftClick);
			// 
			// tbAlignCenter
			// 
			this.tbAlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbAlignCenter.Image = ((System.Drawing.Image)(resources.GetObject("tbAlignCenter.Image")));
			this.tbAlignCenter.ImageTransparentColor = System.Drawing.Color.White;
			this.tbAlignCenter.Name = "tbAlignCenter";
			this.tbAlignCenter.Size = new System.Drawing.Size(23, 22);
			this.tbAlignCenter.Text = "toolStripButton2";
			this.tbAlignCenter.ToolTipText = "Centralizar";
			this.tbAlignCenter.Click += new System.EventHandler(this.TbAlignCenterClick);
			// 
			// tbAlignRight
			// 
			this.tbAlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbAlignRight.Image = ((System.Drawing.Image)(resources.GetObject("tbAlignRight.Image")));
			this.tbAlignRight.ImageTransparentColor = System.Drawing.Color.White;
			this.tbAlignRight.Name = "tbAlignRight";
			this.tbAlignRight.Size = new System.Drawing.Size(23, 22);
			this.tbAlignRight.Text = "toolStripButton3";
			this.tbAlignRight.ToolTipText = "Alinhar à direita";
			this.tbAlignRight.Click += new System.EventHandler(this.TbAlignRightClick);
			// 
			// tbJustify
			// 
			this.tbJustify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbJustify.Image = ((System.Drawing.Image)(resources.GetObject("tbJustify.Image")));
			this.tbJustify.ImageTransparentColor = System.Drawing.Color.White;
			this.tbJustify.Name = "tbJustify";
			this.tbJustify.Size = new System.Drawing.Size(23, 22);
			this.tbJustify.Text = "toolStripButton4";
			this.tbJustify.ToolTipText = "Justificar";
			this.tbJustify.Click += new System.EventHandler(this.TbJustifyClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// tbBold
			// 
			this.tbBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbBold.Image = ((System.Drawing.Image)(resources.GetObject("tbBold.Image")));
			this.tbBold.ImageTransparentColor = System.Drawing.Color.White;
			this.tbBold.Name = "tbBold";
			this.tbBold.Size = new System.Drawing.Size(23, 22);
			this.tbBold.Text = "toolStripButton5";
			this.tbBold.ToolTipText = "Negrito";
			this.tbBold.Click += new System.EventHandler(this.TbBoldClick);
			// 
			// tbItalic
			// 
			this.tbItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbItalic.Image = ((System.Drawing.Image)(resources.GetObject("tbItalic.Image")));
			this.tbItalic.ImageTransparentColor = System.Drawing.Color.White;
			this.tbItalic.Name = "tbItalic";
			this.tbItalic.Size = new System.Drawing.Size(23, 22);
			this.tbItalic.Text = "toolStripButton6";
			this.tbItalic.ToolTipText = "Itálico";
			this.tbItalic.Click += new System.EventHandler(this.TbItalicClick);
			// 
			// tbUnderline
			// 
			this.tbUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbUnderline.Image = ((System.Drawing.Image)(resources.GetObject("tbUnderline.Image")));
			this.tbUnderline.ImageTransparentColor = System.Drawing.Color.White;
			this.tbUnderline.Name = "tbUnderline";
			this.tbUnderline.Size = new System.Drawing.Size(23, 22);
			this.tbUnderline.Text = "toolStripButton7";
			this.tbUnderline.ToolTipText = "Sublinhado";
			this.tbUnderline.Click += new System.EventHandler(this.TbUnderlineClick);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// tbUnorderedList
			// 
			this.tbUnorderedList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbUnorderedList.Image = ((System.Drawing.Image)(resources.GetObject("tbUnorderedList.Image")));
			this.tbUnorderedList.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbUnorderedList.Name = "tbUnorderedList";
			this.tbUnorderedList.Size = new System.Drawing.Size(23, 22);
			this.tbUnorderedList.Text = "toolStripButton8";
			this.tbUnorderedList.ToolTipText = "Lista não-ordenada";
			// 
			// tbOrderedList
			// 
			this.tbOrderedList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbOrderedList.Image = ((System.Drawing.Image)(resources.GetObject("tbOrderedList.Image")));
			this.tbOrderedList.ImageTransparentColor = System.Drawing.Color.White;
			this.tbOrderedList.Name = "tbOrderedList";
			this.tbOrderedList.Size = new System.Drawing.Size(23, 22);
			this.tbOrderedList.Text = "toolStripButton9";
			this.tbOrderedList.ToolTipText = "Lista ordenada";
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// tbSubScript
			// 
			this.tbSubScript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbSubScript.Image = ((System.Drawing.Image)(resources.GetObject("tbSubScript.Image")));
			this.tbSubScript.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbSubScript.Name = "tbSubScript";
			this.tbSubScript.Size = new System.Drawing.Size(23, 22);
			this.tbSubScript.Text = "toolStripButton10";
			this.tbSubScript.ToolTipText = "Subscrito";
			// 
			// tbSuperScript
			// 
			this.tbSuperScript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbSuperScript.Image = ((System.Drawing.Image)(resources.GetObject("tbSuperScript.Image")));
			this.tbSuperScript.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbSuperScript.Name = "tbSuperScript";
			this.tbSuperScript.Size = new System.Drawing.Size(23, 22);
			this.tbSuperScript.Text = "toolStripButton11";
			this.tbSuperScript.ToolTipText = "Sobrescrito";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			// 
			// cbFontFace
			// 
			this.cbFontFace.AutoSize = false;
			this.cbFontFace.Name = "cbFontFace";
			this.cbFontFace.Size = new System.Drawing.Size(121, 23);
			this.cbFontFace.SelectedIndexChanged += new System.EventHandler(this.CbFontFaceSelectedIndexChanged);
			// 
			// cbFontSize
			// 
			this.cbFontSize.AutoSize = false;
			this.cbFontSize.Items.AddRange(new object[] {
			"5",
			"6",
			"7",
			"8",
			"9",
			"10",
			"11",
			"12",
			"14",
			"16",
			"18",
			"20",
			"22",
			"24",
			"26",
			"28",
			"38",
			"48",
			"64",
			"72"});
			this.cbFontSize.Name = "cbFontSize";
			this.cbFontSize.Size = new System.Drawing.Size(50, 23);
			this.cbFontSize.SelectedIndexChanged += new System.EventHandler(this.CbFontSizeSelectedIndexChanged);
			// 
			// ssbFontColor
			// 
			this.ssbFontColor.AutoSize = false;
			this.ssbFontColor.BackColor = System.Drawing.SystemColors.Control;
			this.ssbFontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ssbFontColor.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ssbFontColor.Image = ((System.Drawing.Image)(resources.GetObject("ssbFontColor.Image")));
			this.ssbFontColor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ssbFontColor.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.ssbFontColor.Name = "ssbFontColor";
			this.ssbFontColor.Size = new System.Drawing.Size(52, 22);
			this.ssbFontColor.Text = "A";
			this.ssbFontColor.ToolTipText = "Cor da fonte";
			this.ssbFontColor.ButtonClick += new System.EventHandler(this.SsbFontColorButtonClick);
			this.ssbFontColor.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.SsbFontColorDropDownItemClicked);
			this.ssbFontColor.Paint += new System.Windows.Forms.PaintEventHandler(this.SsbFontColorPaint);
			// 
			// ssbBackColor
			// 
			this.ssbBackColor.AutoSize = false;
			this.ssbBackColor.BackColor = System.Drawing.SystemColors.Control;
			this.ssbBackColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ssbBackColor.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ssbBackColor.Image = ((System.Drawing.Image)(resources.GetObject("ssbBackColor.Image")));
			this.ssbBackColor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ssbBackColor.ImageTransparentColor = System.Drawing.Color.White;
			this.ssbBackColor.Name = "ssbBackColor";
			this.ssbBackColor.Size = new System.Drawing.Size(52, 22);
			this.ssbBackColor.Text = "A";
			this.ssbBackColor.ToolTipText = "Cor do fundo";
			this.ssbBackColor.ButtonClick += new System.EventHandler(this.SsbBackColorButtonClick);
			this.ssbBackColor.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.SsbBackColorDropDownItemClicked);
			this.ssbBackColor.Paint += new System.Windows.Forms.PaintEventHandler(this.SsbBackColorPaint);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
			// 
			// cbZoom
			// 
			this.cbZoom.AutoSize = false;
			this.cbZoom.Name = "cbZoom";
			this.cbZoom.Size = new System.Drawing.Size(60, 23);
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
			// 
			// tbFind
			// 
			this.tbFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbFind.Image = ((System.Drawing.Image)(resources.GetObject("tbFind.Image")));
			this.tbFind.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbFind.Name = "tbFind";
			this.tbFind.Size = new System.Drawing.Size(23, 22);
			this.tbFind.Text = "toolStripButton12";
			this.tbFind.ToolTipText = "Pesquisar";
			// 
			// tbReplace
			// 
			this.tbReplace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbReplace.Image = ((System.Drawing.Image)(resources.GetObject("tbReplace.Image")));
			this.tbReplace.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbReplace.Name = "tbReplace";
			this.tbReplace.Size = new System.Drawing.Size(23, 22);
			this.tbReplace.Text = "toolStripButton12";
			this.tbReplace.ToolTipText = "Substituir";
			// 
			// toolStripSeparator10
			// 
			this.toolStripSeparator10.Name = "toolStripSeparator10";
			this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
			// 
			// tbAutomaticIdent
			// 
			this.tbAutomaticIdent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbAutomaticIdent.Image = ((System.Drawing.Image)(resources.GetObject("tbAutomaticIdent.Image")));
			this.tbAutomaticIdent.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbAutomaticIdent.Name = "tbAutomaticIdent";
			this.tbAutomaticIdent.Size = new System.Drawing.Size(23, 22);
			this.tbAutomaticIdent.Text = "toolStripButton12";
			this.tbAutomaticIdent.ToolTipText = "Indentação automática";
			// 
			// tbLineBreak
			// 
			this.tbLineBreak.CheckOnClick = true;
			this.tbLineBreak.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbLineBreak.Image = ((System.Drawing.Image)(resources.GetObject("tbLineBreak.Image")));
			this.tbLineBreak.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbLineBreak.Name = "tbLineBreak";
			this.tbLineBreak.Size = new System.Drawing.Size(23, 22);
			this.tbLineBreak.Text = "toolStripButton13";
			this.tbLineBreak.ToolTipText = "Quebra de linha automática";
			// 
			// menuPrincipal
			// 
			this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.arquivoToolStripMenuItem,
			this.editarToolStripMenuItem,
			this.exibirToolStripMenuItem,
			this.inserirToolStripMenuItem,
			this.formatarToolStripMenuItem,
			this.configuraçõesToolStripMenuItem});
			this.menuPrincipal.Location = new System.Drawing.Point(2, 2);
			this.menuPrincipal.Name = "menuPrincipal";
			this.menuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.menuPrincipal.Size = new System.Drawing.Size(1073, 24);
			this.menuPrincipal.TabIndex = 3;
			// 
			// arquivoToolStripMenuItem
			// 
			this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.novaAnotacaoToolStripMenuItem,
			this.salvarAnotacaoToolStripMenuItem,
			this.excluirAnotacaoToolStripMenuItem,
			this.toolStripMenuItem2,
			this.importarArquivoToolStripMenuItem,
			this.exportarAnotacaoToolStripMenuItem,
			this.toolStripMenuItem1,
			this.visualizarImpressaoToolStripMenuItem,
			this.toolStripMenuItem3,
			this.sairToolStripMenuItem});
			this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
			this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.arquivoToolStripMenuItem.Text = "&Arquivo";
			// 
			// novaAnotacaoToolStripMenuItem
			// 
			this.novaAnotacaoToolStripMenuItem.Name = "novaAnotacaoToolStripMenuItem";
			this.novaAnotacaoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.novaAnotacaoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.novaAnotacaoToolStripMenuItem.Text = "N&ova anotação...";
			this.novaAnotacaoToolStripMenuItem.Click += new System.EventHandler(this.NovaAnotacaoToolStripMenuItemClick);
			// 
			// salvarAnotacaoToolStripMenuItem
			// 
			this.salvarAnotacaoToolStripMenuItem.Name = "salvarAnotacaoToolStripMenuItem";
			this.salvarAnotacaoToolStripMenuItem.ShortcutKeyDisplayString = "";
			this.salvarAnotacaoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.salvarAnotacaoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.salvarAnotacaoToolStripMenuItem.Text = "&Salvar anotação";
			this.salvarAnotacaoToolStripMenuItem.Click += new System.EventHandler(this.SalvarAnotaçãoToolStripMenuItemClick);
			// 
			// excluirAnotacaoToolStripMenuItem
			// 
			this.excluirAnotacaoToolStripMenuItem.Name = "excluirAnotacaoToolStripMenuItem";
			this.excluirAnotacaoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.excluirAnotacaoToolStripMenuItem.Text = "&Excluir anotação...";
			this.excluirAnotacaoToolStripMenuItem.Click += new System.EventHandler(this.ExcluirAnotacaoToolStripMenuItemClick);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(203, 6);
			// 
			// importarArquivoToolStripMenuItem
			// 
			this.importarArquivoToolStripMenuItem.Name = "importarArquivoToolStripMenuItem";
			this.importarArquivoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.importarArquivoToolStripMenuItem.Text = "&Importar arquivo...";
			// 
			// exportarAnotacaoToolStripMenuItem
			// 
			this.exportarAnotacaoToolStripMenuItem.Name = "exportarAnotacaoToolStripMenuItem";
			this.exportarAnotacaoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.exportarAnotacaoToolStripMenuItem.Text = "E&xportar anotação...";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(203, 6);
			// 
			// visualizarImpressaoToolStripMenuItem
			// 
			this.visualizarImpressaoToolStripMenuItem.Name = "visualizarImpressaoToolStripMenuItem";
			this.visualizarImpressaoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.visualizarImpressaoToolStripMenuItem.Text = "&Visualizar impressão";
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(203, 6);
			// 
			// sairToolStripMenuItem
			// 
			this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
			this.sairToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.sairToolStripMenuItem.Text = "Sai&r";
			this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItemClick);
			// 
			// editarToolStripMenuItem
			// 
			this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.desfazerToolStripMenuItem,
			this.refazerToolStripMenuItem,
			this.toolStripMenuItem4,
			this.recortarToolStripMenuItem,
			this.copiarToolStripMenuItem,
			this.colarToolStripMenuItem,
			this.colarEspecialToolStripMenuItem,
			this.selecionartudoToolStripMenuItem,
			this.toolStripMenuItem5,
			this.localizarToolStripMenuItem,
			this.localizarProximoToolStripMenuItem,
			this.localizarAnteriorToolStripMenuItem,
			this.substituirToolStripMenuItem,
			this.toolStripMenuItem6,
			this.procurarAnotacoesToolStripMenuItem,
			this.alterarCategoriaToolStripMenuItem});
			this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
			this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
			this.editarToolStripMenuItem.Text = "&Editar";
			// 
			// desfazerToolStripMenuItem
			// 
			this.desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
			this.desfazerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.desfazerToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.desfazerToolStripMenuItem.Text = "&Desfazer";
			this.desfazerToolStripMenuItem.Click += new System.EventHandler(this.DesfazerToolStripMenuItemClick);
			// 
			// refazerToolStripMenuItem
			// 
			this.refazerToolStripMenuItem.Name = "refazerToolStripMenuItem";
			this.refazerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
			this.refazerToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.refazerToolStripMenuItem.Text = "R&efazer";
			this.refazerToolStripMenuItem.Click += new System.EventHandler(this.RefazerToolStripMenuItemClick);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(244, 6);
			// 
			// recortarToolStripMenuItem
			// 
			this.recortarToolStripMenuItem.Name = "recortarToolStripMenuItem";
			this.recortarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.recortarToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.recortarToolStripMenuItem.Text = "&Recortar";
			this.recortarToolStripMenuItem.Click += new System.EventHandler(this.RecortarToolStripMenuItemClick);
			// 
			// copiarToolStripMenuItem
			// 
			this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
			this.copiarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.copiarToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.copiarToolStripMenuItem.Text = "&Copiar";
			this.copiarToolStripMenuItem.Click += new System.EventHandler(this.CopiarToolStripMenuItemClick);
			// 
			// colarToolStripMenuItem
			// 
			this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
			this.colarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.colarToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.colarToolStripMenuItem.Text = "C&olar";
			this.colarToolStripMenuItem.Click += new System.EventHandler(this.ColarToolStripMenuItemClick);
			// 
			// colarEspecialToolStripMenuItem
			// 
			this.colarEspecialToolStripMenuItem.Name = "colarEspecialToolStripMenuItem";
			this.colarEspecialToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
			| System.Windows.Forms.Keys.V)));
			this.colarEspecialToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.colarEspecialToolStripMenuItem.Text = "Colar e&special...";
			// 
			// selecionartudoToolStripMenuItem
			// 
			this.selecionartudoToolStripMenuItem.Name = "selecionartudoToolStripMenuItem";
			this.selecionartudoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.selecionartudoToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.selecionartudoToolStripMenuItem.Text = "Selecionar &tudo";
			this.selecionartudoToolStripMenuItem.Click += new System.EventHandler(this.SelecionartudoToolStripMenuItemClick);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(244, 6);
			// 
			// localizarToolStripMenuItem
			// 
			this.localizarToolStripMenuItem.Name = "localizarToolStripMenuItem";
			this.localizarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.localizarToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.localizarToolStripMenuItem.Text = "&Localizar...";
			// 
			// localizarProximoToolStripMenuItem
			// 
			this.localizarProximoToolStripMenuItem.Name = "localizarProximoToolStripMenuItem";
			this.localizarProximoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
			this.localizarProximoToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.localizarProximoToolStripMenuItem.Text = "Localizar &próximo";
			// 
			// localizarAnteriorToolStripMenuItem
			// 
			this.localizarAnteriorToolStripMenuItem.Name = "localizarAnteriorToolStripMenuItem";
			this.localizarAnteriorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
			this.localizarAnteriorToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.localizarAnteriorToolStripMenuItem.Text = "Localizar &anterior";
			// 
			// substituirToolStripMenuItem
			// 
			this.substituirToolStripMenuItem.Name = "substituirToolStripMenuItem";
			this.substituirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.substituirToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.substituirToolStripMenuItem.Text = "S&ubstituir...";
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(244, 6);
			// 
			// procurarAnotacoesToolStripMenuItem
			// 
			this.procurarAnotacoesToolStripMenuItem.Name = "procurarAnotacoesToolStripMenuItem";
			this.procurarAnotacoesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.procurarAnotacoesToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.procurarAnotacoesToolStripMenuItem.Text = "&Procurar nas anotações...";
			// 
			// alterarCategoriaToolStripMenuItem
			// 
			this.alterarCategoriaToolStripMenuItem.Name = "alterarCategoriaToolStripMenuItem";
			this.alterarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
			this.alterarCategoriaToolStripMenuItem.Text = "&Alterar categoria...";
			this.alterarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.MiAlterarCategoriaClick);
			// 
			// exibirToolStripMenuItem
			// 
			this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.barraDestatusToolStripMenuItem,
			this.barraDeferramentasToolStripMenuItem,
			this.toolStripMenuItem7,
			this.irParaToolStripMenuItem,
			this.contarPalavrasToolStripMenuItem,
			this.toolStripMenuItem8,
			this.quickNoteToolStripMenuItem});
			this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
			this.exibirToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.exibirToolStripMenuItem.Text = "E&xibir";
			// 
			// barraDestatusToolStripMenuItem
			// 
			this.barraDestatusToolStripMenuItem.Name = "barraDestatusToolStripMenuItem";
			this.barraDestatusToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.barraDestatusToolStripMenuItem.Text = "Barra de &status";
			// 
			// barraDeferramentasToolStripMenuItem
			// 
			this.barraDeferramentasToolStripMenuItem.Name = "barraDeferramentasToolStripMenuItem";
			this.barraDeferramentasToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.barraDeferramentasToolStripMenuItem.Text = "Barra de &ferramentas";
			// 
			// toolStripMenuItem7
			// 
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			this.toolStripMenuItem7.Size = new System.Drawing.Size(180, 6);
			// 
			// irParaToolStripMenuItem
			// 
			this.irParaToolStripMenuItem.Name = "irParaToolStripMenuItem";
			this.irParaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
			this.irParaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.irParaToolStripMenuItem.Text = "&Ir para...";
			// 
			// contarPalavrasToolStripMenuItem
			// 
			this.contarPalavrasToolStripMenuItem.Name = "contarPalavrasToolStripMenuItem";
			this.contarPalavrasToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.contarPalavrasToolStripMenuItem.Text = "&Contar palavras";
			// 
			// toolStripMenuItem8
			// 
			this.toolStripMenuItem8.Name = "toolStripMenuItem8";
			this.toolStripMenuItem8.Size = new System.Drawing.Size(180, 6);
			// 
			// quickNoteToolStripMenuItem
			// 
			this.quickNoteToolStripMenuItem.Name = "quickNoteToolStripMenuItem";
			this.quickNoteToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.quickNoteToolStripMenuItem.Text = "&Quick Note";
			// 
			// inserirToolStripMenuItem
			// 
			this.inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
			this.inserirToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
			this.inserirToolStripMenuItem.Text = "&Inserir";
			// 
			// formatarToolStripMenuItem
			// 
			this.formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
			this.formatarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.formatarToolStripMenuItem.Text = "&Formatar";
			// 
			// configuraçõesToolStripMenuItem
			// 
			this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
			this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
			this.configuraçõesToolStripMenuItem.Text = "&Configurações";
			// 
			// openFileDialog
			// 
			this.openFileDialog.DefaultExt = "*.*";
			this.openFileDialog.Title = "Arquivo para importação";
			// 
			// iconMenu
			// 
			this.iconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.iconMenuMinimizar,
			this.toolStripMenuItem12,
			this.iconMenuSair});
			this.iconMenu.Name = "iconMenu";
			this.iconMenu.Size = new System.Drawing.Size(128, 54);
			// 
			// iconMenuMinimizar
			// 
			this.iconMenuMinimizar.Name = "iconMenuMinimizar";
			this.iconMenuMinimizar.Size = new System.Drawing.Size(127, 22);
			this.iconMenuMinimizar.Text = "&Minimizar";
			this.iconMenuMinimizar.Click += new System.EventHandler(this.IconMenuMinimizarClick);
			// 
			// toolStripMenuItem12
			// 
			this.toolStripMenuItem12.Name = "toolStripMenuItem12";
			this.toolStripMenuItem12.Size = new System.Drawing.Size(124, 6);
			// 
			// iconMenuSair
			// 
			this.iconMenuSair.Name = "iconMenuSair";
			this.iconMenuSair.Size = new System.Drawing.Size(127, 22);
			this.iconMenuSair.Text = "Sai&r";
			this.iconMenuSair.Click += new System.EventHandler(this.SairToolStripMenuItemClick);
			// 
			// splitPrincipal
			// 
			this.splitPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitPrincipal.Location = new System.Drawing.Point(2, 51);
			this.splitPrincipal.Name = "splitPrincipal";
			this.splitPrincipal.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitPrincipal.Panel1
			// 
			this.splitPrincipal.Panel1.Controls.Add(this.splitAnnotationList);
			this.splitPrincipal.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			// 
			// splitPrincipal.Panel2
			// 
			this.splitPrincipal.Panel2.Controls.Add(this.reText);
			this.splitPrincipal.Panel2.Controls.Add(this.statusBar);
			this.splitPrincipal.Panel2.Controls.Add(this.panel1);
			this.splitPrincipal.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.splitPrincipal.Size = new System.Drawing.Size(1073, 436);
			this.splitPrincipal.SplitterDistance = 130;
			this.splitPrincipal.TabIndex = 6;
			this.splitPrincipal.TabStop = false;
			// 
			// frPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1077, 489);
			this.Controls.Add(this.splitPrincipal);
			this.Controls.Add(this.toolBar);
			this.Controls.Add(this.menuPrincipal);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MainMenuStrip = this.menuPrincipal;
			this.Name = "frPrincipal";
			this.Padding = new System.Windows.Forms.Padding(2);
			this.Text = "MyNotesFree.net - Anote tudo em um só lugar - v";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrPrincipalFormClosed);
			this.Shown += new System.EventHandler(this.FrPrincipalShown);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrPrincipalKeyDown);
			this.Resize += new System.EventHandler(this.FrPrincipalResize);
			this.splitAnnotationList.Panel1.ResumeLayout(false);
			this.splitAnnotationList.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitAnnotationList)).EndInit();
			this.splitAnnotationList.ResumeLayout(false);
			this.menuLvAnnotations.ResumeLayout(false);
			this.menuEditor.ResumeLayout(false);
			this.statusBar.ResumeLayout(false);
			this.statusBar.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.toolBar.ResumeLayout(false);
			this.toolBar.PerformLayout();
			this.menuPrincipal.ResumeLayout(false);
			this.menuPrincipal.PerformLayout();
			this.iconMenu.ResumeLayout(false);
			this.splitPrincipal.Panel1.ResumeLayout(false);
			this.splitPrincipal.Panel2.ResumeLayout(false);
			this.splitPrincipal.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitPrincipal)).EndInit();
			this.splitPrincipal.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
