using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace OurDecorApplication.Views
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ToProducts_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProductsPage());
        }

        private void ToMaterials_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MaterialsPage());
        }

        private void Out_click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}
