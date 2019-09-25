/*
 * Created by SharpDevelop.
 * User: Roque.Possamai
 * Date: 26/07/2019
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MyNotesFree.database;
using MyNotesFree.database.dao;
using MyNotesFree.database.entity;

namespace MyNotesFree
{
	/// <summary>
	/// Description of frCategoryList.
	/// </summary>
	public partial class frCategoryList : Form
	{
		
		private CategoryDAO categoryDao = new CategoryDAO();
		private List<Category> categories;
		private int categoryId;
		
		public frCategoryList()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			categories = categoryDao.listAll();
			categories.Sort((x, y) => string.Compare(x.Description, y.Description, StringComparison.CurrentCulture));
				
			lvCategories.BeginUpdate();
			try {
				foreach (var category in categories) {
					addCategoryListView(category);
				}
				
				if (categories.Count > 0) {
					lvCategories.Items[0].Selected = true;
					btnSelecionar.Enabled = true;
				}
			} finally {
				lvCategories.EndUpdate();
			}
		}
		
		private void addCategoryListView(Category category) {
			var item = lvCategories.Items.Add(category.Description);
			item.SubItems.Add(category.Font);
			item.SubItems.Add((category.Selected == 1 ? "Sim" : "Não"));
			item.Tag = category.Id;
		}

		public int CategoryId {
			get {
				return categoryId;
			}
		}
		
		void EbPesquisaKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Down) {
				e.SuppressKeyPress = true;
				//Se está no primeiro item, move para o segundo
				if (lvCategories.Items.Count > 1 && lvCategories.SelectedItems.Count > 0 && lvCategories.SelectedItems[0].Equals(lvCategories.Items[0])) {
					lvCategories.Items[1].Selected = true;
					lvCategories.Items[1].Focused = true;
				} else {
					lvCategories.Items[0].Selected = true;
				}
				lvCategories.Select();
			}
		}
		
		void BtnSelecionarClick(object sender, EventArgs e)
		{
			if (lvCategories.SelectedItems.Count > 0) {
				categoryId = (int) lvCategories.SelectedItems[0].Tag;
			}
		}
		
		void LvCategoriesDrawItem(object sender, DrawListViewItemEventArgs e)
		{
//			e.DrawDefault = true;
		}
		
		void LvCategoriesDrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
		{
			e.DrawDefault = true;
		}
		
		void LvCategoriesDrawSubItem(object sender, DrawListViewSubItemEventArgs e)
		{
	        String text = (e.ColumnIndex == 0 ? e.Item.Text : e.SubItem.Text);

	        e.DrawBackground();
	        if (e.Item.Selected) 
	        {
	        	e.Graphics.FillRectangle(new SolidBrush(Color.CornflowerBlue), e.Bounds);
		        e.Graphics.DrawString(text, lvCategories.Font, new SolidBrush(Color.White), e.Bounds);
	        } else {
	        	e.Graphics.DrawString(text, lvCategories.Font, new SolidBrush(Color.Black), e.Bounds);
	        }
		}
		
		/**
		 * Aplica o filtro conforme a digitação ocorre
		 */
		void EdPesquisaTextChanged(object sender, EventArgs e)
		{
			btnSelecionar.Enabled = false;
			lvCategories.BeginUpdate();
			lvCategories.Items.Clear();
			try {
				foreach (var category in categories) {
					if (category.Description.ToUpper().Contains(edPesquisa.Text.ToUpper())) {
						addCategoryListView(category);
					}
				}
			} finally {
				if (lvCategories.Items.Count > 0)
					lvCategories.Items[0].Selected = true;
				lvCategories.EndUpdate();
			}
		}
		
		void LvCategoriesItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			btnSelecionar.Enabled = lvCategories.SelectedItems.Count > 0;
		}
	}
}
