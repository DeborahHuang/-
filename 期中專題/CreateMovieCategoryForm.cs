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
	public partial class CreateMovieCategoryForm : Form
	{
		public CreateMovieCategoryForm()
		{
			InitializeComponent();
		}

		private void saveButton_Click_1(object sender, EventArgs e)
		{
			string categoryName = categoryNameTextBox.Text;
			int displayOrder= displayOrderTextBox.Text.ToInt(-1);

			MovieCategoryVM model = new MovieCategoryVM
			{
				CategoryName = categoryName,
				DisplayOrder= displayOrder
			};

			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{ "DisplayOrder", displayOrderTextBox},
				{ "CategoryName", categoryNameTextBox},
			};

			bool isValid = ValidationHelper.Validate(model, map, this.errorProvider1);
			if (!isValid) return;

			try
			{
				new MovieCategoryService().CreateMovieCategory(model);
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"新增失敗,原因:{ex.Message}");
			}
		}
	}
}
