using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 期中專題.Infra;
using 期中專題.Infra.Extensions;
using 期中專題.Models.Services;
using 期中專題.Models.ViewModels;

namespace 期中專題
{
	public partial class CreateMovieForm : Form
	{
		public CreateMovieForm()
		{
			InitializeComponent();
			InitForm();
		}
		public void InitForm()
		{
			string sql = @"SELECT * FROM MovieCategories ORDER BY DisplayOrder ";
			var dbHelper = new SqlDbHelper("default");

			IEnumerable<MovieCategoryVM> categories = dbHelper.Select(sql, null)
						.AsEnumerable().Select(x =>ToMovieCategoryVM(x))
						.ToList();
			categoryNameComboBox.DataSource = categories;
		}
		private MovieCategoryVM ToMovieCategoryVM(DataRow x)
		{
			return new MovieCategoryVM()
			{
				Id = x.Field<int>("Id"),
				CategoryName = x.Field<string>("CategoryName"),
				DisplayOrder = x.Field<int>("DisplayOrder")
			};
		}
		private void saveButton_Click(object sender, EventArgs e)
		{
			int categoryId = ((MovieCategoryVM)categoryNameComboBox.SelectedItem).Id;
			string movieTitle = movieTitleTextBox.Text;
			int rental = rentalTextBox.Text.ToInt(-1);

			MovieVM model = new MovieVM()
			{
				CategoryId = categoryId,
				MovieTitle = movieTitle,
				Rental = rental,
			};

			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{ "CategoryId", categoryNameComboBox},
				{ "MovieTitle", movieTitleTextBox},
				{ "Rental",rentalTextBox}
			};

			bool isValid = ValidationHelper.Validate(model, map, this.errorProvider1);
			if (!isValid) return;

			try
			{
				new MovieService().CreateMovie(model);
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"新增失敗,原因:{ex.Message}");
			}
		}
	}
}
