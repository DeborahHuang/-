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
	public partial class OrdersForm : Form
	{
		private OrderIndexVM[] orders = null;
		public OrdersForm()
		{
			InitializeComponent();
			InitForm();
			DisplayOrders();
		}

		public void InitForm()
		{			
			string sql = @"SELECT * FROM Members M JOIN Orders O ON M.Id=O.MemberId
									JOIN MovieCategories C ON C.Id=O.MovieCategoryId
									JOIN Movies ON Movies.Id=O.MovieId";

			var dbHelper = new SqlDbHelper("default");

			IEnumerable<OrderVM> orders = dbHelper.Select(sql, null)
						.AsEnumerable().Select(x => ToOrderVM(x))
						.Prepend(new OrderVM { Id = 0, CategoryName = string.Empty })
						.ToList();
		}

		private static OrderVM ToOrderVM(DataRow x)
		{
			return new OrderVM()
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
				Rental= x.Field<int>("Rental"),
			};
		}

		private void DisplayOrders()
		{
			orders = new OrderService().GetAll().ToArray();
			BindData(orders);
		}

		private void BindData(OrderIndexVM[] orders)
		{
			dataGridView1.DataSource = orders;
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;

			if (rowIndx < 0) return;

			OrderIndexVM row = this.orders[rowIndx];
			int id = row.Id;
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			var frm = new CreateOrderForm();
			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK)
			{
				DisplayOrders();
			}
		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			DisplayOrderByPhone();
		}

		public void DisplayOrderByPhone()
		{
			string sql = @"SELECT * FROM Members M JOIN Orders O ON M.Id=O.MemberId
									JOIN MovieCategories C ON C.Id=O.MovieCategoryId
									JOIN Movies ON Movies.Id=O.MovieId ";

			SqlParameter[] parameters = new SqlParameter[] { };

			string phoneNumber = phoneNumberTextBox.Text;

			
				sql += " WHERE PhoneNumber=@PhoneNumber";
				parameters = new SqlParameterBuilder()
					.AddNvarchar("PhoneNumber",50, phoneNumber)
					.Build();
			
			var dbHelper = new SqlDbHelper("default");

			orders = dbHelper.Select(sql, parameters)
				.AsEnumerable()
				.Select(row => ParseToOrderIndexVM(row))
				.ToArray();

			BindData(orders);
			if (string.IsNullOrEmpty(phoneNumber)) DisplayOrders();
		}

		private OrderIndexVM ParseToOrderIndexVM(DataRow row)
		{
			return new OrderIndexVM
			{
				Id = row.Field<int>("Id"),
				MovieCategoryId= row.Field<int>("MovieCategoryId"),
				CategoryName= row.Field<string>("CategoryName"),
				MovieId= row.Field<int>("MovieId"),
				MovieTitle= row.Field<string>("MovieTitle"),
				MemberId= row.Field<int>("MemberId"),
				Rental= row.Field<int>("Rental"),
				Name = row.Field<string>("Name"),
				Account = row.Field<string>("Account"),
				Email = row.Field<string>("Email"),
				PhoneNumber = row.Field<string>("PhoneNumber"),
				OrderDate= row.Field<DateTime>("OrderDate"),
				DeadLine = row.Field<DateTime>("DeadLine"),
			};
		}
	}
}
