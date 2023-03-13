using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WPF_MVVM_ToDo.Other
{
    public class BooleanToBorderThicknessConverter : IValueConverter
    {
        public int TrueThickness { get; set; }
        public int FalseThickness { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is bool))
            {
                return null;
            }

            if ((bool)value)
            {
                return new Thickness(TrueThickness);
            }
            else
            {
                return new Thickness(FalseThickness);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
