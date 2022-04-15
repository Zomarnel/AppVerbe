using System;
using System.Globalization;
using System.Windows.Data;

namespace WPFUI.CustomConverters
{
    public class BooleanToResultConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value == null)
            {
                throw new InvalidCastException("Cannot convert null value.");
            }

            if ((bool)value)
            {
                return LanguageService.Translate("Correct", LanguageService.LastUsedLanguage);
            }
            else
            {
                return LanguageService.Translate("Wrong", LanguageService.LastUsedLanguage);
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
