/*
 * Created by SharpDevelop.
 * User: roque
 * Date: 26/07/2019
 */
namespace MyNotesFree
{
	partial class frCategoryList
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox edPesquisa;
		private System.Windows.Forms.ListView lvCategories;
		private System.Windows.Forms.ColumnHeader chDescription;
		private System.Windows.Forms.ColumnHeader chFont;
		private System.Windows.Forms.ColumnHeader chSelected;
		private System.Windows.Forms.Button btnSelecionar;
		private System.Windows.Forms.Button btnCancelar;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.edPesquisa = new System.Windows.Forms.TextBox();
			this.lvCategories = new System.Windows.Forms.ListView();
			this.chDescription = new System.Windows.Forms.ColumnHeader();
			this.chFont = new System.Windows.Forms.ColumnHeader();
			this.chSelected = new System.Windows.Forms.ColumnHeader();
			this.btnSelecionar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(9, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Pesquisa:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edPesquisa
			// 
			this.edPesquisa.Location = new System.Drawing.Point(64, 8);
			this.edPesquisa.Name = "edPesquisa";
			this.edPesquisa.Size = new System.Drawing.Size(432, 20);
			this.edPesquisa.TabIndex = 1;
			this.edPesquisa.TextChanged += new System.EventHandler(this.EdPesquisaTextChanged);
			this.edPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EbPesquisaKeyDown);
			// 
			// lvCategories
			// 
			this.lvCategories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.chDescription,
			this.chFont,
			this.chSelected});
			this.lvCategories.FullRowSelect = true;
			this.lvCategories.GridLines = true;
			this.lvCategories.HideSelection = false;
			this.lvCategories.Location = new System.Drawing.Point(12, 36);
			this.lvCategories.MultiSelect = false;
			this.lvCategories.Name = "lvCategories";
			this.lvCategories.OwnerDraw = true;
			this.lvCategories.Size = new System.Drawing.Size(484, 192);
			this.lvCategories.TabIndex = 2;
			this.lvCategories.UseCompatibleStateImageBehavior = false;
			this.lvCategories.View = System.Windows.Forms.View.Details;
			this.lvCategories.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.LvCategoriesDrawColumnHeader);
			this.lvCategories.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.LvCategoriesDrawItem);
			this.lvCategories.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.LvCategoriesDrawSubItem);
			this.lvCategories.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LvCategoriesItemSelectionChanged);
			// 
			// chDescription
			// 
			this.chDescription.Text = "Descrição";
			this.chDescription.Width = 200;
			// 
			// chFont
			// 
			this.chFont.Text = "Fonte";
			this.chFont.Width = 160;
			// 
			// chSelected
			// 
			this.chSelected.Text = "Selecionada";
			this.chSelected.Width = 80;
			// 
			// btnSelecionar
			// 
			this.btnSelecionar.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnSelecionar.Enabled = false;
			this.btnSelecionar.Location = new System.Drawing.Point(332, 236);
			this.btnSelecionar.Name = "btnSelecionar";
			this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
			this.btnSelecionar.TabIndex = 3;
			this.btnSelecionar.Text = "&Selecionar";
			this.btnSelecionar.UseVisualStyleBackColor = true;
			this.btnSelecionar.Click += new System.EventHandler(this.BtnSelecionarClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancelar.Location = new System.Drawing.Point(420, 236);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 4;
			this.btnCancelar.Text = "&Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			// 
			// frCategoryList
			// 
			this.AcceptButton = this.btnSelecionar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancelar;
			this.ClientSize = new System.Drawing.Size(507, 268);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSelecionar);
			this.Controls.Add(this.lvCategories);
			this.Controls.Add(this.edPesquisa);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "frCategoryList";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Selecione uma categoria";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
