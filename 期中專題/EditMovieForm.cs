using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 期中專題.Infra.Extensions;
using 期中專題.Models.Services;
using 期中專題.Models.ViewModels;

namespace 期中專題
{
	public partial class EditMovieForm : Form
	{
		private int id;
		public EditMovieForm(int id)
		{
			InitializeComponent();
			InitForm();
			this.id = id;
		}
		private void InitForm()
		{
			categoryNameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

			var sql = "SELECT * FROM MovieCategories ORDER BY DisplayOrder";
			var dbHelper = new SqlDbHelper("default");

			List<MovieCategoryVM> categories = dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ToMovieCategoryVM(row))
				.ToList();

			this.categoryNameComboBox.DataSource = categories;
		}

		private MovieCategoryVM ToMovieCategoryVM(DataRow row)
		{
			return new MovieCategoryVM()
			{
				Id = row.Field<int>("Id"),
				CategoryName = row.Field<string>("CategoryName"),
				DisplayOrder = row.Field<int>("DisplayOrder")
			};
		}
		private void EditMovieForm_Load(object sender, EventArgs e)
		{
			BindData(id);
		}

		private void BindData(int id)
		{
			string sql = "SELECT * FROM Movies WHERE Id=@Id";
			var parameters = new SqlParameterBuilder()
				.AddInt("Id", id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				MessageBox.Show("抱歉, 找不到要編輯的記錄");
				this.DialogResult = DialogResult.Abort;
				return;
			}

			MovieVM model = ToMovieVM(data.Rows[0]);

			categoryNameComboBox.SelectedItem = ((List<MovieCategoryVM>)categoryNameComboBox.DataSource)
												.FirstOrDefault(x => x.Id == model.CategoryId);

			categoryNameComboBox.SelectedItem= model.CategoryName;
			movieTitleTextBox.Text = model.MovieTitle;
			rentalTextBox.Text = model.Rental.ToString();
		}

		private MovieVM ToMovieVM(DataRow dataRow)
		{
			return new MovieVM
			{
				Id = dataRow.Field<int>("Id"),
				CategoryId = dataRow.Field<int>("CategoryId"),
				MovieTitle = dataRow.Field<string>("MovieTitle"),
				Rental = dataRow.Field<int>("Rental")
			};
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			if (MessageBox
				.Show("您真的要刪除嗎?",
						"刪除記錄",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question) != DialogResult.Yes)
			{
				return;
			}

			new MovieService().Delete(this.id);

			MessageBox.Show("紀錄已刪除!");

			this.DialogResult = DialogResult.OK;
		}

		private void updateButton_Click(object sender, EventArgs e)
		{
			
			int categoryId = ((MovieCategoryVM)this.categoryNameComboBox.SelectedItem).Id;
			string movieTitle = movieTitleTextBox.Text;
			int rental = rentalTextBox.Text.ToInt(-1); 

			
			MovieVM model = new MovieVM
			{
				CategoryId = categoryId,
				MovieTitle = movieTitle,
				Rental = rental
			};

			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"CategoryId", categoryNameComboBox},
				{ "MovieTitle", movieTitleTextBox},
				{ "Rental", rentalTextBox},
			};

			string sql = @"UPDATE Movies SET CategoryId=@CategoryId, 
					MovieTitle=@MovieTitle, Rental = @Rental WHERE Id=@Id";

			var parameters = new SqlParameterBuilder()
				.AddInt("CategoryId", model.CategoryId)
				.AddNvarchar("MovieTitle", 50, model.MovieTitle)
				.AddInt("Rental", model.Rental)
				.AddInt("Id", this.id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

			this.DialogResult = DialogResult.OK;
		}
	}
}
