using System;
using System.Globalization;
using System.Windows.Data;

namespace WPFUI.CustomConverters
{
    public class HalfValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {   

            double totalHeight = (double)value;
            return (object)(totalHeight / 2);

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
