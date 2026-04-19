using BuildingShopApplication.Views;
using System.Windows;

namespace BuildingShopApplication
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new LoginPage());
        }
    }
}