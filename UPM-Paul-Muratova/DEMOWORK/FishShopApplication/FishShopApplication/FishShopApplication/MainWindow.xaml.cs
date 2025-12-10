using FishShopApplication.View;
using System.Windows;

namespace FishShopApplication
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