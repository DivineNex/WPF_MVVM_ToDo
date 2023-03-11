using System;
using System.Globalization;
using System.Windows.Data;

namespace WPF_MVVM_ToDo.Other
{
    internal class PlaceholderConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var searchText = values[0]?.ToString();
            var placeholder = values[1]?.ToString();

            if (string.IsNullOrEmpty(searchText))
            {
                return placeholder;
            }

            return searchText;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            return new object[] { value.ToString() };
        }
    }
}
