using System.Windows;
using EntityFrameworkLearn.Views;

namespace EntityFrameworkLearn
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new CharactersPage());
        }
    }
}