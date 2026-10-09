using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lab1_5_MAUI_XAML
{
    internal class FloatToIntConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
                              object parameter, CultureInfo culture)
        {
            float multiplier;
            if (!float.TryParse(parameter as string, out multiplier))
                multiplier = 1;
            return (int)Math.Round(multiplier * (float)value);
        }

        public object ConvertBack(object value, Type targetType,
                                  object parameter, CultureInfo culture)
        {
            float divider;
            if (!float.TryParse(parameter as string, out divider))
                divider = 1;
            return ((float)(int)value) / divider;
        }
    }
}
