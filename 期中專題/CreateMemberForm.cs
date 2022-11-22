using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 期中專題.Infra;
using 期中專題.Models.Services;
using 期中專題.Models.ViewModels;

namespace 期中專題
{
	public partial class CreateMemberForm : Form
	{
		public CreateMemberForm()
		{
			InitializeComponent();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			string name = nameTextBox.Text;
			string account = accountTextBox.Text;
			string password = passwordTextBox.Text;
			string email = emailTextBox.Text;
			string phoneNumber = phoneNumberTextBox.Text;

			MemberVM model = new MemberVM
			{
				Name=name,
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
				new UserService().Create(model);
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"新增失敗,原因:{ex.Message}");
			}
		}
	}
}
