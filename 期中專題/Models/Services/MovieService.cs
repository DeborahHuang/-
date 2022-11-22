using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 期中專題.Models.ViewModels;

namespace 期中專題.Models.Services
{
	public class MovieService
	{
		public IEnumerable<MovieIndexVM> GetAll()
		{
			string sql = @"SELECT * FROM Movies M JOIN MovieCategories C ON M.CategoryId=C.Id ";
			var dbHelper = new SqlDbHelper("default");
			SqlParameter[] parameters = new SqlParameter[] { };
			return dbHelper.Select(sql, parameters)
				.AsEnumerable()
				.Select(row => ParseToMovieIndexVM(row));
		}

		private MovieCategoryIndexVM ParseToMovieCategoryIndexVM(DataRow row)
		{
			return new MovieCategoryIndexVM
			{
				Id = row.Field<int>("Id"),
				CategoryName = row.Field<string>("CategoryName"),
			};
		}

		private MovieIndexVM ParseToMovieIndexVM(DataRow row)
		{
			return new MovieIndexVM
			{
				Id = row.Field<int>("Id"),
				CategoryId = row.Field<int>("CategoryId"),
				CategoryName = row.Field<string>("CategoryName"),
				DisplayOrder = row.Field<int>("DisplayOrder"),
				MovieTitle = row.Field<string>("MovieTitle"),
				Rental= row.Field<int>("Rental"),
			};
		}

		private MovieCategoryVM ToMovieCategoryVM(DataRow x)
		{
			return new MovieCategoryVM()
			{
				Id = x.Field<int>("id"),
				CategoryName = x.Field<string>("CategoryName"),
				DisplayOrder = x.Field<int>("DisplayOrder")
			};
		}

		public void CreateMovie(MovieVM model)
		{
			bool isExist = MovieExist(model.MovieTitle);
			if (isExist==true) throw new Exception("已經有這部電影了");

			string sql = @"INSERT INTO Movies(CategoryId,MovieTitle,Rental)
							VALUES(@CategoryId,@MovieTitle,@Rental)";

			var parameters = new SqlParameterBuilder()
				.AddInt("CategoryId", model.CategoryId)
				.AddNvarchar("MovieTitle", 50, model.MovieTitle)
				.AddInt("Rental",  model.Rental)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}

		private bool MovieExist(string movieTitle)
		{
			string sql = @"SELECT COUNT (*) AS count FROM Movies WHERE MovieTitle=@MovieTitle";

			var parameters = new SqlParameterBuilder()
				.AddNvarchar("MovieTitle", 50, movieTitle)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			return data.Rows[0].Field<int>("count") > 0;
		}

		public void Delete(int id)
		{
			string sql = @"DELETE FROM Movies WHERE Id=@Id";

			var parameters = new SqlParameterBuilder()
				.AddInt("Id", id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
	}
}
