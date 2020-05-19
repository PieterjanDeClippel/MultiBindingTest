using System;
using System.Globalization;
using System.Linq;
using Xamarin.Forms;

namespace MultiBindingTest.Converters
{
    public class BooleanOrConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var result = values.Any((val) => ((val is bool) && ((bool)val)));

            if (targetType == typeof(bool))
            {
                return result;
            }
            else
            {
                return result;
            }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException($"{nameof(BooleanAndConverter)} can only be used with BindingMode=OneWay");
        }
    }
}
