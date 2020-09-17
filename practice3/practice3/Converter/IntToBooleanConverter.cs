using System;
using System.Globalization;
using Xamarin.Forms;

namespace practice3.Converter
{
    public class IntToBooleanConverter : IValueConverter
    {
        public IntToBooleanConverter()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int minimumLength = System.Convert.ToInt32(parameter);

            return (int)value >= minimumLength;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
