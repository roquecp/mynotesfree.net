/*
 * Created by SharpDevelop.
 * User: roque.possamai
 * Date: 18/11/2019
 * Time: 18:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MyNotesFree
{
	partial class frCategory
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox cbMustHide;
		private System.Windows.Forms.TextBox edDescription;
		private System.Windows.Forms.TextBox edBackColor;
		private System.Windows.Forms.TextBox edFontColor;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnTestColor;
		
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cbMustHide = new System.Windows.Forms.CheckBox();
			this.edDescription = new System.Windows.Forms.TextBox();
			this.edBackColor = new System.Windows.Forms.TextBox();
			this.edFontColor = new System.Windows.Forms.TextBox();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnTestColor = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(22, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Descrição:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(22, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Cor de fundo:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(22, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Cor da fonte:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbMustHide
			// 
			this.cbMustHide.Location = new System.Drawing.Point(92, 99);
			this.cbMustHide.Name = "cbMustHide";
			this.cbMustHide.Size = new System.Drawing.Size(245, 24);
			this.cbMustHide.TabIndex = 3;
			this.cbMustHide.Text = "Sempre oculta (exceto quando selecionado)";
			this.cbMustHide.UseVisualStyleBackColor = true;
			// 
			// edDescription
			// 
			this.edDescription.Location = new System.Drawing.Point(92, 18);
			this.edDescription.Name = "edDescription";
			this.edDescription.Size = new System.Drawing.Size(323, 20);
			this.edDescription.TabIndex = 4;
			// 
			// edBackColor
			// 
			this.edBackColor.Location = new System.Drawing.Point(92, 47);
			this.edBackColor.Name = "edBackColor";
			this.edBackColor.Size = new System.Drawing.Size(323, 20);
			this.edBackColor.TabIndex = 5;
			// 
			// edFontColor
			// 
			this.edFontColor.Location = new System.Drawing.Point(92, 73);
			this.edFontColor.Name = "edFontColor";
			this.edFontColor.Size = new System.Drawing.Size(323, 20);
			this.edFontColor.TabIndex = 6;
			// 
			// btnCancelar
			// 
			this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancelar.Location = new System.Drawing.Point(340, 138);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 8;
			this.btnCancelar.Text = "&Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// btnSalvar
			// 
			this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnSalvar.Location = new System.Drawing.Point(252, 138);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(75, 23);
			this.btnSalvar.TabIndex = 7;
			this.btnSalvar.Text = "&Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.BtnSalvarClick);
			// 
			// btnTestColor
			// 
			this.btnTestColor.FlatAppearance.BorderSize = 0;
			this.btnTestColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTestColor.Location = new System.Drawing.Point(92, 129);
			this.btnTestColor.Name = "btnTestColor";
			this.btnTestColor.Size = new System.Drawing.Size(75, 23);
			this.btnTestColor.TabIndex = 9;
			this.btnTestColor.Text = "Teste Cor";
			this.btnTestColor.UseVisualStyleBackColor = true;
			// 
			// frCategory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(435, 178);
			this.Controls.Add(this.btnTestColor);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.edFontColor);
			this.Controls.Add(this.edBackColor);
			this.Controls.Add(this.edDescription);
			this.Controls.Add(this.cbMustHide);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "frCategory";
			this.Text = "Cadastro de categorias";
			this.Shown += new System.EventHandler(this.FrCategoryShown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
