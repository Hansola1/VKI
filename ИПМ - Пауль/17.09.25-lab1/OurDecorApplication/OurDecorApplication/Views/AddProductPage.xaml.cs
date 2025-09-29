using System.Windows;
using System.Windows.Controls;

namespace OurDecorApplication.Views
{
    public partial class AddProductPage : Page
    {
        public AddProductPage()
        {
            InitializeComponent();
            LoadStateComboBox();
        }

        private void LoadStateComboBox()
        {
            //StateSelector.Items.Add("В наличии");
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
