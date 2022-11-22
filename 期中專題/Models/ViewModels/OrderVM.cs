using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 期中專題.Models.ViewModels
{
	public class OrderVM: IValidatableObject
	{
		public int Id { get; set; }
		public int MovieCategoryId { get; set; }
		public string CategoryName  { get; set; }
		public int MovieId { get; set; }
		public string MovieTitle { get; set; }
		public int MemberId { get; set; }
		public int Rental { get; set; }

		public string Name { get; set; }
		public string Account { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		public DateTime OrderDate { get; set; }
		public DateTime DeadLine { get; set; }

		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			if (MemberId <= 0) yield return new ValidationResult("會員ID必填", new string[] { "MemberId" });
			if (MovieTitle == string.Empty) yield return new ValidationResult("電影名稱必填", new string[] { "MovieTitle" });
			if (MovieCategoryId <= 0) yield return new ValidationResult("電影類別必填", new string[] { "MovieCategoryId" });
		}
	}

	public class OrderIndexVM
	{
		public int Id { get; set; }

		public int MovieCategoryId { get; set; }
		public string CategoryName { get; set; }
		public int MovieId { get; set; }		
		public string MovieTitle { get; set; }
		public int MemberId { get; set; }
		public int Rental { get; set; }
		public string Name { get; set; }
		public string Account { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		public DateTime OrderDate { get; set; }
		public DateTime DeadLine { get; set; }
	}
}
