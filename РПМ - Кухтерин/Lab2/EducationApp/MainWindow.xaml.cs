using EducationApp.Model;
using System.Windows;
using System.Windows.Navigation;

namespace EducationApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new MainMenuPage());
        }
    }
}