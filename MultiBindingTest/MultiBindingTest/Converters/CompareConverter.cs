using System;
using System.Globalization;
using System.Linq;
using Xamarin.Forms;

namespace MultiBindingTest.Converters
{
    public class CompareConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter.GetType() != typeof(string))
                throw new ArgumentException($@"Value for {nameof(CompareConverter)}.{nameof(Binding.ConverterParameter)} must be ""<"", "">"" or ""="".");
            if (values.Length != 2)
                throw new ArgumentException($"Number of binding values must be exactly 2. Current number of binding values: {values.Length}");
            if (values.Any(v => v == null))
                return false;

            var op = parameter.ToString();
            double left, right;
            if (!double.TryParse(values[0].ToString(), out left))
                return false;
            if (!double.TryParse(values[1].ToString(), out right))
                return false;

            switch (op)
            {
                case "<":
                    return left < right;
                case ">":
                    return left > right;
                case "=":
                    return left == right;
                default:
                    throw new ArgumentException($@"Value for {nameof(CompareConverter)}.{nameof(Binding.ConverterParameter)} must be ""<"", "">"" or ""="".");
            }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
