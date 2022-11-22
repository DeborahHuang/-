using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 期中專題.Models.Services;
using 期中專題.Models.ViewModels;

namespace 期中專題
{
	public partial class MembersForm : Form
	{
		private MemberIndexVM[] members = null;

		public MembersForm()
		{
			InitializeComponent();
			DisplayMembers();
			DisplayMemberByPhone();
		}
		private void DisplayMembers()
		{
			members = new UserService().GetAll().ToArray();
			BindData(members);
		}

		private void BindData(MemberIndexVM[] members)
		{
			dataGridView1.DataSource = members;
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;

			if (rowIndx < 0) return;

			MemberIndexVM row = this.members[rowIndx];

			int id = row.Id; 
			var frm = new EditMemberForm(id);

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayMembers();
			}
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			var frm = new CreateMemberForm();
			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK)
			{
				DisplayMembers();
			}
		}

		private void MembersForm_Load(object sender, EventArgs e)
		{
			DisplayMembers();
		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			DisplayMemberByPhone();
		}

		public void DisplayMemberByPhone()
		{
			string sql = @"SELECT * FROM Members WHERE PhoneNumber=@PhoneNumber";

			SqlParameter[] parameters = new SqlParameter[] { };

			string phoneNumber = phoneNumberTextBox.Text;

			parameters = new SqlParameterBuilder()
					.AddNvarchar("PhoneNumber", 50,phoneNumber)
					.Build();
			
			var dbHelper = new SqlDbHelper("default");
	
			MemberIndexVM[] phoneNumbers = dbHelper.Select(sql, parameters)
				.AsEnumerable()
				.Select(row => ParseToMovieIndexVM(row))
				.ToArray();
	
			BindData(phoneNumbers);
			if (string.IsNullOrEmpty(phoneNumber)) DisplayMembers();
		}

		private MemberIndexVM ParseToMovieIndexVM(DataRow row)
		{
			return new MemberIndexVM
			{
				Id = row.Field<int>("Id"),
				Name = row.Field<string>("Name"),
				Account = row.Field<string>("Account"),
				Email = row.Field<string>("Email"),
				PhoneNumber = row.Field<string>("PhoneNumber"),
			};
		}
	}
}
