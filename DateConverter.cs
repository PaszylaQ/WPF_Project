using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace VehicleWPF.Converters
{
    public class DateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                DateTime date = (DateTime)value;
                return date.ToString("yyyy");

            }
            return String.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                try
                {
                    DateTime date = DateTime.ParseExact(value.ToString(), "yyyy", null);
                    return date;
                }
                catch (FormatException)
                {
                    return value;
                }
            }
            return String.Empty;
        }
    }
}
