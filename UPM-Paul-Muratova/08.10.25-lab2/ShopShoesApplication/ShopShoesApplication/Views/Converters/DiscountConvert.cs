using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace ShopShoesApplication.Views.Converters
{
    public class DiscountConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int discount)
            {
                if (discount > 15)
                    return new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2E8B57"));
            }
            return Brushes.White; // по умолчанию будет
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
