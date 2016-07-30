using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace AlbionEconDesktop.view
{
    class ProfitToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((int) value > 0) return Brushes.Green;
            return Brushes.Red;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
