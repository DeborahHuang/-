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
using System.Xml.Linq;
using 期中專題.Infra;
using 期中專題.Models.Services;
using 期中專題.Models.ViewModels;

namespace 期中專題
{
	public partial class EditMemberForm : Form
	{
		private int id;
		public EditMemberForm(int id)
		{
			InitializeComponent(); 
			this.id = id;
		}

		private void EditMemberForm_Load(object sender, EventArgs e)
		{
			BindData(id);
		}

		private void BindData(int id)
		{
			string sql = "SELECT * FROM Members WHERE Id=@Id";
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

			nameTextBox.Text = row.Field<string>("Name");
			accountTextBox.Text = row.Field<string>("Account");
			passwordTextBox.Text = row.Field<string>("Password");
			emailTextBox.Text = row.Field<string>("Email");
			phoneNumberTextBox.Text = row.Field<string>("PhoneNumber");
		}
		private void updateButton_Click(object sender, EventArgs e)
		{
			string name = nameTextBox.Text;
			string account = accountTextBox.Text;
			string password = passwordTextBox.Text;
			string email = emailTextBox.Text;
			string phoneNumber = phoneNumberTextBox.Text;

			MemberVM model = new MemberVM
			{
				Id = this.id,
				Name = name,
				Account = account,
				Password = password,
				Email = email,
				PhoneNumber = phoneNumber,
			};

			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{ "Name", nameTextBox},
				{ "Account", accountTextBox},
				{ "Password",passwordTextBox},
				{ "Email", emailTextBox},
				{ "PhoneNumber", phoneNumberTextBox},
			};
			bool isValid = ValidationHelper.Validate(model, map, this.errorProvider1);
			if (!isValid) return;

			try
			{
				new UserService().Update(model);
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

			new UserService().Delete(this.id);
			MessageBox.Show("紀錄已刪除!");
			this.DialogResult = DialogResult.OK;
		}
	}
}
