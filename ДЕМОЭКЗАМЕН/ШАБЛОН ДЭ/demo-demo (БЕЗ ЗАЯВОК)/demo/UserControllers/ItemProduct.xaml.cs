using demo.Models;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace demo.UserControllers
{
    public partial class ItemProduct : UserControl
    {
        private string projPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        public double discount { get; set; } = 0;
        public ItemProduct(Product product)
        {
            InitializeComponent();
            DataContext = product;

            string path = product.ImagePath == null ? Path.Combine(projPath, "Images", "Defaults", "picture.png") : Path.Combine(projPath, "Images", product.ImagePath);
            
            Uri uri = new Uri(path);
            try
            {
                BitmapImage bitmap = new(uri);
                BoxImage.Source = bitmap;
            }
            catch (Exception ex)//любая ошибка с изобращением
            {
                Console.WriteLine(ex.Message);
                BitmapImage bitmap = new(new Uri(Path.Combine(projPath, "Images", "Defaults", "picture.png")));
                BoxImage.Source = bitmap;
            }

            if (product.Discount >= 15)
            {
                BoxDiscount.Background = new BrushConverter().ConvertFrom("#2E8B57") as SolidColorBrush;
            }
            if (product.Discount > 0)
            {
                BoxPrice.Foreground = Brushes.Red;
                BoxPrice.TextDecorations.Add(TextDecorations.Strikethrough);

                BoxNewPrice.Text = (product.Price * (1 - product.Discount / 100.0)).ToString();
            }

            if (product.Count == 0)
            {
                BoxCount.Foreground = Brushes.Blue;
            }
        }
    }
}
