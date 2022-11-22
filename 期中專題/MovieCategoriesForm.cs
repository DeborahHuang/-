using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 期中專題.Models.Services;
using 期中專題.Models.ViewModels;

namespace 期中專題
{
	public partial class MovieCategoriesForm : Form
	{
		private MovieCategoryIndexVM[] categories = null;
		public MovieCategoriesForm()
		{
			InitializeComponent();
			DisplayMovieCategory();
		}

		private static MovieCategoryVM ToMovieCategoryVM(DataRow x)
		{
			return new MovieCategoryVM()
			{
				Id = x.Field<int>("Id"),
				CategoryName = x.Field<string>("CategoryName"),
				DisplayOrder = x.Field<int>("DisplayOrder")
			};
		}

		private void DisplayMovieCategory()
		{
			categories = new MovieCategoryService().GetAllMovieCategory().ToArray();
			BindData(categories);
		}

		private MovieCategoryIndexVM ParseToMovieCategoryIndexVM(DataRow row)
		{
			return new MovieCategoryIndexVM
			{
				Id = row.Field<int>("Id"),
				CategoryName = row.Field<string>("CategoryName"),
				DisplayOrder = row.Field<int>("DisplayOrder")
			};
		}

		private void BindData(MovieCategoryIndexVM[] categories)
		{
			dataGridView1.DataSource = categories;
		}
	
		private void addButton_Click(object sender, EventArgs e)
		{
			var frm = new CreateMovieCategoryForm();
			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK)
			{
				DisplayMovieCategory();
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;

			if (rowIndx < 0) return;

			MovieCategoryIndexVM row = this.categories[rowIndx]; 
			int id = row.Id; 

			var frm = new EditMovieCategoryForm(id);

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayMovieCategory();
			}
		}

		private void MovieCategoriesForm_Load(object sender, EventArgs e)
		{

		}
	}
}
