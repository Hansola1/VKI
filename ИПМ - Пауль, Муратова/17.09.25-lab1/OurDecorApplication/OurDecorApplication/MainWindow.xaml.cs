using OurDecorApplication.Views;
using System.Windows;

namespace OurDecorApplication
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new MainPage());
        }
    }
}