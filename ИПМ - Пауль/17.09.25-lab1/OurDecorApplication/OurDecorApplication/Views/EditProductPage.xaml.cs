using System.Windows;
using System.Windows.Controls;

namespace OurDecorApplication.Views
{
    public partial class EditProductPage : Page
    {
        public EditProductPage()
        {
            InitializeComponent();
        }
        private void Save_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProductsPage());
        }

        private void Cancel_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProductsPage());
        }
    }
}
