using ElectronicShopApplication.Views;
using System.Windows;

namespace ElectronicShopApplication
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