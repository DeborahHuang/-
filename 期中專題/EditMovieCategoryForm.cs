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
	public partial class EditMovieCategoryForm : Form
	{
		private int id;
		public EditMovieCategoryForm(int id)
		{
			InitializeComponent();
			this.id = id;
		}
		private void EditMovieCategoryForm_Load_1(object sender, EventArgs e)
		{
			BindData(id);
		}
		private void BindData(int id)
		{
			string sql = "SELECT * FROM MovieCategories WHERE Id=@Id";
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

			DataRow row = data.Rows[0];

			categoryNameTextBox.Text = row.Field<string>("CategoryName");
			displayOrderTextBox.Text = row.Field<int>("DisplayOrder").ToString();
		}
		private void updateButton_Click_1(object sender, EventArgs e)
		{
			string categoryName = categoryNameTextBox.Text;
			int displayOrder=displayOrderTextBox.Text.ToInt(-1);

			MovieCategoryVM model = new MovieCategoryVM
			{
				Id = this.id,
				CategoryName = categoryName,
				DisplayOrder=displayOrder
			};

			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{ "CategoryName", categoryNameTextBox},
				{ "DisplayOrder", displayOrderTextBox},
			};
			bool isValid = ValidationHelper.Validate(model, map, this.errorProvider1);
			if (!isValid) return;

			try
			{
				new MovieCategoryService().UpdateCategoryName(model);
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"更新失敗,原因:{ex.Message}");
			}
			this.DialogResult = DialogResult.OK;
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

			new MovieCategoryService().Delete(this.id);
			MessageBox.Show("紀錄已刪除!");
			this.DialogResult = DialogResult.OK;
		}
	}
}
