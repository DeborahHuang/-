using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 期中專題.Models.ViewModels;
using System.Security.Principal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace 期中專題.Models.Services
{
	public class UserService
	{
		public IEnumerable<MemberIndexVM> GetAll()
		{
			string sql = @"SELECT * FROM Members ORDER BY Name";
			var dbHelper = new SqlDbHelper("default");
			SqlParameter[] parameters = new SqlParameter[] { };
			return dbHelper.Select(sql, parameters)
				.AsEnumerable()
				.Select(row => ParseToMemberIndexVM(row));
		}

		public void Create(MemberVM model)
		{
			bool isExist = AccountExist(model.Account);
			bool phoneIsExist = PhoneNumberExist(model.PhoneNumber);
			bool EmailIsExist = EmailExist(model.Email);
			if (isExist) throw new Exception("帳號已存在");
			if (phoneIsExist|| EmailIsExist) throw new Exception("您已註冊過");

			string sql = @"INSERT INTO Members(Name,Account,Password, Email,PhoneNumber)
							VALUES(@Name,@Account,@Password,@Email,@PhoneNumber)";

			var parameters = new SqlParameterBuilder()
				.AddNvarchar("Name", 50, model.Name)
				.AddNvarchar("Account", 50, model.Account)
				.AddNvarchar("Password", 50, model.Password)
				.AddNvarchar("Email", 50, model.Email)
				.AddNvarchar("PhoneNumber", 50, model.PhoneNumber)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}

		public bool AccountExist(string account)
		{
			string sql = @"SELECT COUNT (*) AS count FROM Members WHERE Account=@Account";

			var parameters = new SqlParameterBuilder()
				.AddNvarchar("Account", 50, account)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			return data.Rows[0].Field<int>("count") > 0;
		}

		public bool EmailExist(string email)
		{
			string sql = @"SELECT COUNT (*) AS count FROM Members WHERE Email=@Email";

			var parameters = new SqlParameterBuilder()
				.AddNvarchar("Email", 50, email)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			return data.Rows[0].Field<int>("count") > 0;
		}

		public bool PhoneNumberExist(string phoneNumber)
		{
			string sql = @"SELECT COUNT (*) AS count FROM Members WHERE PhoneNumber=@PhoneNumber";

			var parameters = new SqlParameterBuilder()
				.AddNvarchar("PhoneNumber", 50, phoneNumber)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			return data.Rows[0].Field<int>("count") > 0;
		}

		private MemberIndexVM ParseToMemberIndexVM(DataRow row)
		{
			return new MemberIndexVM
			{
				Id = row.Field<int>("Id"),
				Name = row.Field<string>("Name"),
				Account = row.Field<string>("Account"),
				Email = row.Field<string>("Email"),
				PhoneNumber = row.Field<string>("PhoneNumber")
			};
		}

		public void Update(MemberVM model)
		{
			bool isExist = AccountExist(model.Account);
			string sql = @"UPDATE Members SET Name = @Name,Account=@Account, Password=@Password, 
							Email = @Email,PhoneNumber = @PhoneNumber WHERE Id=@Id";

			var parameters = new SqlParameterBuilder()
				.AddInt("Id", model.Id)
				.AddNvarchar("Name", 50, model.Name)
				.AddNvarchar("Account", 50, model.Account)
				.AddNvarchar("Password", 50, model.Password)
				.AddNvarchar("Email", 50, model.Email)
				.AddNvarchar("PhoneNumber", 50, model.PhoneNumber)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}

		public MemberVM Get(string account)
		{
			string sql = @"SELECT * FROM Members WHERE Account=@Account";
			var parameters = new SqlParameterBuilder()
				.AddNvarchar("Account", 50, account)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			if (data.Rows.Count == 0)
			{
				return null;
			}
			return MemberVM(data.Rows[0]);
		}

		private MemberVM MemberVM(DataRow row)
		{
			return new MemberVM
			{
				Id = row.Field<int>("Id"),
				Name = row.Field<string>("Name"),
				Account = row.Field<string>("Account"),
				Password = row.Field<string>("Password"),
				Email = row.Field<string>("Email"),
				PhoneNumber = row.Field<string>("PhoneNumber"),
			};
		}

		public void Delete(int id)
		{
			string sql = @"DELETE FROM Members WHERE Id=@Id";

			var parameters = new SqlParameterBuilder()
				.AddInt("Id", id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}

		internal bool Authenticate(LoginVM model)
		{
			var user = Get(model.Account);
			if (user == null) return false; 

			return (user.Password == model.Password);
		}
	}
}
