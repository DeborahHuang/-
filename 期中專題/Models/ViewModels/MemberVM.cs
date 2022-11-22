using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 期中專題.Models.ViewModels
{
	public class MemberVM
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "姓名必填")]
		public string Name { get; set; }

		[Required(ErrorMessage = "帳號必填")]
		public string Account { get; set; }

		[Required(ErrorMessage = "密碼必填")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Email必填")]
		[EmailAddress(ErrorMessage = "Email格式錯誤")]
		public string Email { get; set; }

		[Required(ErrorMessage = "手機必填")]
		public string PhoneNumber { get; set; }

	}

	public class MemberIndexVM
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public string Account { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
	}
}
