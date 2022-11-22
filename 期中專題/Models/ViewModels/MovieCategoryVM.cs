using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期中專題.Models.Services
{
	public class MovieCategoryVM : IValidatableObject
	{
		public int Id { get; set; }
		public string CategoryName { get; set; }
		public int DisplayOrder { get; set; }
		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			if (DisplayOrder <= 0) yield return new ValidationResult("編號必填", new string[] { "DisplayOrder" });
			if (CategoryName==string.Empty) yield return new ValidationResult("電影類別必填", new string[] { "CategoryName" });
		}
	}
	public class MovieCategoryIndexVM
	{
		public int Id { get; set; }
		public string CategoryName { get; set; }
		public int DisplayOrder { get; set; }
	}
}
