using CarsharingApp.Views;
using System.Windows;

namespace CarsharingApp
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