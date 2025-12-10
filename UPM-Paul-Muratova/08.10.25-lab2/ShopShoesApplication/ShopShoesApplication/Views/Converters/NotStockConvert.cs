using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace ShopShoesApplication.Views.Converters
{
    public class NotStockConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int Count)
            {
                if (Count == 0)
                    return new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00bfff"));
            }
            return Brushes.White; // по умолчанию будет
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
