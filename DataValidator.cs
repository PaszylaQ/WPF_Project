using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace VehicleWPF.Validation
{
    public class DataValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            DateTime date;
            try
            {
                date = DateTime.ParseExact(value.ToString(), "yyyy", null);
                Console.WriteLine(date.ToString());
            }
            catch (FormatException)
            {
                return new ValidationResult(false, "Value is not a valid date.");
            }
            if (DateTime.Now.Date <= date.Date)
                return new ValidationResult(false, "Please enter a date in the past.");
            else
                return ValidationResult.ValidResult;
        }
    }
}
