using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期中專題.Infra
{
	internal class ValidationHelper
	{
		public static bool Validate<T>(T model, Dictionary<string, Control> map, ErrorProvider errorProvider)
		{
			ValidationContext context = new ValidationContext(model, null, null);
			List<ValidationResult> errors = new List<ValidationResult>();
			errorProvider.Clear();
			bool validateAllProperties = true;
			bool isvalid = Validator.TryValidateObject(model, context, errors, validateAllProperties);
			if (!isvalid)
			{
				DisplayErrorsByErrorProvider(errors, map, errorProvider);
			}
			return isvalid;
		}

		public static void DisplayErrorsByErrorProvider(List<ValidationResult> errors, Dictionary<string, Control> map, ErrorProvider errorProvider)
		{
			foreach (ValidationResult error in errors)
			{
				string proName = error.MemberNames.FirstOrDefault();
				if (map.TryGetValue(proName, out Control ctrl))
				{
					errorProvider.SetError(ctrl, error.ErrorMessage);
				}
			}
		}
	}
}
