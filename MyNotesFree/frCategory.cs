/*
 * Created by SharpDevelop.
 * User: roque.possamai
 * Date: 18/11/2019
 * Time: 18:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MyNotesFree.database.dao;
using MyNotesFree.database.entity;

namespace MyNotesFree
{
	/// <summary>
	/// Description of frCategory.
	/// </summary>
	public partial class frCategory : Form
	{
		/* ID da categoria... caso o valor seja diferente de zero, 
 		 * significa que está editando uma categoria */
		private int categoryId = 0;
		private CategoryDAO categoryDao = new CategoryDAO();
		
		public frCategory()
		{
			InitializeComponent();
			/*
aliceblue
azure
beige
black
cornsilk
floralwhite
gainsboro
ghostwhite
honeydew
ivory
khaki
lavender
lavenderblush
lemonchiffon
lightcyan
lightgoldenrodyellow
lightyellow
linen
mintcream
moccasin
oldlace
palegoldenrod
papayawhip
seashell
snow
whitesmoke
white

			 */
			defaultColors 
			for (int i = 0; i < defaultColors.Length; i++) {
				var b = new Bitmap(20, 20);
				Graphics.FromImage(b).FillRectangle(new SolidBrush(Color.FromName(defaultColors[i].Name)), 0, 0, 20, 20);
				ssbFontColor.DropDownItems.Add(defaultColors[i].Name).Image = b;
				ssbBackColor.DropDownItems.Add(defaultColors[i].Name).Image = b;  
			}
			ssbFontColor.DropDownItems.Add("-");
			ssbFontColor.DropDownItems.Add(MORE_COLOR_NAME);

		}

		public int CategoryId {
			get {
				return categoryId;
			} 
			set {
				categoryId = value;
			}
		}
		
		void FrCategoryShown(object sender, EventArgs e)
		{
			if (categoryId > 0) {
				var categ = categoryDao.get(categoryId);
				edDescription.Text = categ.Description;
				edBackColor.Text = categ.Color;
				edFontColor.Text = categ.Font;
				cbMustHide.Checked = categ.MustHide == 1;
			} else {
				edBackColor.Text = "white";
				edFontColor.Text = "black";
			}
		}
		
		void BtnSalvarClick(object sender, EventArgs e)
		{
			var category = (categoryId == 0 ? new Category() : categoryDao.get(categoryId));
			category.Description = edDescription.Text;
			category.Editable = 1;
			category.MustHide = (cbMustHide.Checked ? 1 : 0);
			category.Color = edBackColor.Text;
			category.Font = edFontColor.Text;
			category.Selected = 0;
			
			if (categoryId == 0) {
				categoryDao.insert(category);
			} else {
				categoryDao.update(category);
			}
			this.Close();
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
