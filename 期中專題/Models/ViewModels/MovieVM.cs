using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 期中專題.Models.ViewModels
{
	public class MovieVM: IValidatableObject
	{
		public int Id { get; set; }
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }
		public int DisplayOrder { get; set; }
		public string MovieTitle { get; set; }
		public int Rental { get; set; }

		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			if (Rental <= 0) yield return new ValidationResult("租金必填", new string[] { "Rental" });
			if (CategoryName == string.Empty) yield return new ValidationResult("電影類別必填", new string[] { "CategoryName" });
			if (MovieTitle == string.Empty) yield return new ValidationResult("電影名稱必填", new string[] { "MovieTitle" });
		}
	}

	public class MovieIndexVM
	{
		public int Id { get; set; }
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }
		public int DisplayOrder { get; set; }
		public string MovieTitle { get; set; }
		public int Rental { get; set; }
	}
}
