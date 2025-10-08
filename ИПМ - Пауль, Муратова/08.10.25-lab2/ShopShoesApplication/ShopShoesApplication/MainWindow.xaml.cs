using ShopShoesApplication.Views;
using System.Windows;

namespace ShopShoesApplication
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