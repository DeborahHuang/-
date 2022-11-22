using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using 期中專題.Models.ViewModels;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace 期中專題.Models.Services
{
	public class OrderService
	{
		public IEnumerable<OrderIndexVM> GetAll()
		{
			string sql = @"SELECT * FROM Members M JOIN Orders O ON M.Id=O.MemberId
									JOIN MovieCategories C ON C.Id=O.MovieCategoryId
									JOIN Movies ON Movies.Id=O.MovieId";
			var dbHelper = new SqlDbHelper("default");
			SqlParameter[] parameters = new SqlParameter[] { };
			return dbHelper.Select(sql, parameters)
				.AsEnumerable()
				.Select(row => ParseToOrderIndexVM(row));
		}

		private OrderIndexVM ParseToOrderIndexVM(DataRow row)
		{
			return new OrderIndexVM
			{
				Id = row.Field<int>("Id"),
				MovieCategoryId = row.Field<int>("MovieCategoryId"),
				CategoryName = row.Field<string>("CategoryName"),
				MovieId = row.Field<int>("MovieId"),
				MovieTitle= row.Field<string>("MovieTitle"),
				MemberId= row.Field<int>("MemberId"),
				Name= row.Field<string>("Name"),
				Account= row.Field<string>("Account"),
				Password= row.Field<string>("Password"),
				Email= row.Field<string>("Email"),
				PhoneNumber = row.Field<string>("PhoneNumber"),
				Rental = row.Field<int>("Rental"),
				OrderDate= row.Field<DateTime>("OrderDate"),
				DeadLine = row.Field<DateTime>("DeadLine"),

			};
		}
		public void CreateOrder(OrderVM model)
		{
			bool isExist = OrderExist(model.MovieId, model.MemberId);
			bool isOverDL = DateTime.Now < model.DeadLine;
			if (isExist&& isOverDL) throw new Exception("您已租借此電影!");

			string sql = @"INSERT INTO Orders(MovieCategoryId,MovieId,MemberId,OrderDate,DeadLine)
							VALUES(@MovieCategoryId,@MovieId,@MemberId,@OrderDate,@DeadLine)";

			var parameters = new SqlParameterBuilder()
				.AddInt("MovieCategoryId",model.MovieCategoryId)
				.AddInt("MovieId", model.MovieId)
				.AddInt("MemberId", model.MemberId)
				.AddDatetime("OrderDate", model.OrderDate)
				.AddDatetime("DeadLine", model.DeadLine)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}

		private bool OrderExist(int movieId,int memberId)
		{
			string sql = @"SELECT COUNT (*) AS count FROM Orders WHERE MovieId=@MovieId AND MemberId=@MemberId";

			var parameters = new SqlParameterBuilder()
				.AddInt("MovieId", movieId)
				.AddInt("MemberId", memberId)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			return data.Rows[0].Field<int>("count") > 0;
		}

		private bool IsOverDeadLine(DateTime dt)
		{
			string sql = @"SELECT Orders.DeadLine FROM Orders JOIN Movies 
							ON Movies.Id=Orders.MovieId WHERE Orders.DeadLine=@DeadLine";

			var parameters = new SqlParameterBuilder()
				.AddDatetime("DeadLine", dt)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return DateTime.Now > data.Rows[0].Field<DateTime>("DeadLine") ;
		}

		public void UpdateCategoryName(MovieCategoryVM model)
		{

			string sql = @"UPDATE MovieCategories SET CategoryName=@CategoryName,
							DisplayOrder=@DisplayOrder WHERE Id=@Id";

			var parameters = new SqlParameterBuilder()
				.AddInt("Id", model.Id)
				.AddNvarchar("CategoryName", 50, model.CategoryName)
				.AddInt("DisplayOrder", model.DisplayOrder)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}

		public void Delete(int id)
		{
			string sql = @"DELETE FROM Order WHERE Id=@Id";

			var parameters = new SqlParameterBuilder()
				.AddInt("Id", id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
	}
}
