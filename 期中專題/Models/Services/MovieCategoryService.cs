using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 期中專題.Models.ViewModels;

namespace 期中專題.Models.Services
{
	public class MovieCategoryService
	{
		public IEnumerable<MovieCategoryIndexVM> GetAllMovieCategory()
		{
			string sql = @"SELECT * FROM MovieCategories ORDER BY DisplayOrder ";
			var dbHelper = new SqlDbHelper("default");
			SqlParameter[] parameters = new SqlParameter[] { };
			return dbHelper.Select(sql, parameters)
				.AsEnumerable()
				.Select(row => ParseToMovieCategoryIndexVM(row));
		}
		private MovieCategoryIndexVM ParseToMovieCategoryIndexVM(DataRow row)
		{
			return new MovieCategoryIndexVM
			{
				Id = row.Field<int>("Id"),
				CategoryName = row.Field<string>("CategoryName"),
				DisplayOrder = row.Field<int>("DisplayOrder"),
			};
		}
		public void CreateMovieCategory(MovieCategoryVM model)
		{
			bool isExist = MovieCategoryExist(model.CategoryName);
			bool displayOrderExist= DisplayOrderExist(model.DisplayOrder);
			if (isExist) throw new Exception("類別已存在");
			if (displayOrderExist) throw new Exception("編號不能重複");

			string sql = @"INSERT INTO MovieCategories(CategoryName,DisplayOrder)
							VALUES(@CategoryName,@DisplayOrder)";

			var parameters = new SqlParameterBuilder()
				.AddNvarchar("CategoryName", 50, model.CategoryName)
				.AddInt("DisplayOrder", model.DisplayOrder)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
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

		private bool MovieCategoryExist(string categoryName)
		{
			string sql = @"SELECT COUNT (*) AS count FROM MovieCategories WHERE categoryName=@categoryName";

			var parameters = new SqlParameterBuilder()
				.AddNvarchar("categoryName",50, categoryName)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			return data.Rows[0].Field<int>("count") > 0;
		}

		private bool DisplayOrderExist(int displayOrder)
		{
			string sql = @"SELECT COUNT (*) AS count FROM MovieCategories WHERE DisplayOrder=@DisplayOrder";

			var parameters = new SqlParameterBuilder()
				.AddInt("DisplayOrder", displayOrder)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			return data.Rows[0].Field<int>("count") > 0;
		}

		public void Delete(int id)
		{
			string sql = @"DELETE FROM MovieCategories WHERE Id=@Id";

			var parameters = new SqlParameterBuilder()
				.AddInt("Id", id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
	}
}
