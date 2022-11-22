using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 期中專題.Models.Services;
using 期中專題.Models.ViewModels;

namespace 期中專題
{
	public partial class MoviesForm : Form
	{
		private MovieIndexVM[] movies = null;

		public MoviesForm()
		{
			InitializeComponent();
			InitForm();
			DisplayMovies();
		}

		public void InitForm()
		{
			string sql = @"SELECT * FROM MovieCategories ORDER BY DisplayOrder ";
			var dbHelper = new SqlDbHelper("default");

			IEnumerable<MovieCategoryVM> categories = dbHelper.Select(sql, null)
						.AsEnumerable().Select(x => ToMovieCategoryVM(x))
						.Prepend(new MovieCategoryVM { Id = 0, CategoryName = string.Empty })
						.ToList();
			categoryComboBox.DataSource = categories;
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

		public void DisplayMovies()
		{
			string sql = @"SELECT * FROM Movies M JOIN MovieCategories C ON M.CategoryId=C.Id ";

			#region 加入 where 
			SqlParameter[] parameters = new SqlParameter[] { };

			int categoryId = ((MovieCategoryVM)categoryComboBox.SelectedItem).Id;

			if (categoryId > 0)
			{
				sql += " WHERE CategoryId=@CategoryId";
				parameters = new SqlParameterBuilder()
					.AddInt("CategoryId", categoryId)
					.Build();
			}
			#endregion

			sql += " ORDER BY C.CategoryName";
			var dbHelper = new SqlDbHelper("default");
			
			movies = dbHelper.Select(sql, parameters)
				.AsEnumerable()
				.Select(row => ParseToMovieIndexVM(row))
				.ToArray();
		
			BindData(movies);
		}

		private MovieIndexVM ParseToMovieIndexVM(DataRow row)
		{
			return new MovieIndexVM
			{
				Id = row.Field<int>("Id"),
				CategoryId = row.Field<int>("CategoryId"),
				CategoryName= row.Field<string>("CategoryName"),
				MovieTitle = row.Field<string>("MovieTitle"),
				Rental = row.Field<int>("Rental"),
			};
		}

		private void BindData(MovieIndexVM[] movies)
		{
			dataGridView1.DataSource= movies;
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;
			if (rowIndx < 0) return;

			MovieIndexVM row = this.movies[rowIndx];
			int id = row.Id; 
			var frm = new EditMovieForm(id);

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayMovies();
			}
		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			DisplayMovies();
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			var frm = new CreateMovieForm();
			DialogResult result= frm.ShowDialog();

			if (result == DialogResult.OK)
			{
				DisplayMovies();
			}
		}
	}
}
