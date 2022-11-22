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
	public partial class CreateOrderForm : Form
	{
		public CreateOrderForm()
		{
			InitializeComponent();
			InitForm();
		}

		public void InitForm()
		{
			categoryNameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			string sql = @"SELECT * FROM MovieCategories";

			var dbHelper = new SqlDbHelper("default");

			IEnumerable<MovieCategoryVM> categories = dbHelper.Select(sql, null)
						.AsEnumerable().Select(x => TOMovieCategoryVM(x))
						.ToList();
			this.categoryNameComboBox.DataSource = categories;

			string sql2 = @"SELECT * FROM Movies";

			 dbHelper = new SqlDbHelper("default");

			IEnumerable<MovieVM> movieTitles = dbHelper.Select(sql2, null)
						.AsEnumerable().Select(x => ToMovieVM(x))
						.ToList();
			this.movieTitleComboBox.DataSource = movieTitles;
		}

		private MovieVM ToMovieVM(DataRow x)
		{
			return new MovieVM
			{
				Id = x.Field<int>("Id"),
				CategoryId = x.Field<int>("CategoryId"),
				MovieTitle = x.Field<string>("MovieTitle"),
				Rental = x.Field<int>("Rental"),
			};
		}
		private MovieCategoryVM TOMovieCategoryVM(DataRow x)
		{
			return new MovieCategoryVM
			{
				Id = x.Field<int>("Id"),
				CategoryName = x.Field<string>("CategoryName"),
			};
		}
		private OrderIndexVM ToOrderIndexVM(DataRow x)
		{
			return new OrderIndexVM()
			{
				Id = x.Field<int>("Id"),
				MovieCategoryId = x.Field<int>("MovieCategoryId"),
				CategoryName = x.Field<string>("CategoryName"),
				MovieId = x.Field<int>("MovieId"),
				MovieTitle = x.Field<string>("MovieTitle"),
				MemberId = x.Field<int>("MemberId"),
				Name = x.Field<string>("Name"),
				Account = x.Field<string>("Account"),
				Password = x.Field<string>("Password"),
				Email = x.Field<string>("Email"),
				PhoneNumber = x.Field<string>("PhoneNumber"),
				OrderDate=x.Field<DateTime>("OrderDate"),
				DeadLine = x.Field<DateTime>("DeadLine"),
			};
		}
		private void saveButton_Click(object sender, EventArgs e)
		{
			int categoryId = ((MovieCategoryVM)categoryNameComboBox.SelectedItem).Id;
			int movieId = ((MovieVM)movieTitleComboBox.SelectedItem).Id;
			int memberId = memberIdTextBox.Text.ToInt(-1);
			DateTime orderDate = DateTime.Now;
			DateTime deadLine = DateTime.Now.AddDays(3);

			OrderVM model = new OrderVM()
			{
				MovieCategoryId = categoryId,
				MovieId = movieId,
				MemberId = memberId,
				OrderDate=orderDate,
				DeadLine = deadLine,
			};

			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{ "CategoryId", categoryNameComboBox},
				{ "MovieTitle", movieTitleComboBox},
				{ "Account",memberIdTextBox},
				{ "MemberId",memberIdTextBox}
			};

			bool isValid = ValidationHelper.Validate(model, map, this.errorProvider1);
			if (!isValid) return;

			try
			{
				new OrderService().CreateOrder(model);
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"新增失敗,原因:{ex.Message}");
			}
		}
	}
}
