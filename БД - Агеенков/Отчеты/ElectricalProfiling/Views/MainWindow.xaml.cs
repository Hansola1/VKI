using System.Windows;

namespace ElectricalProfiling.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new ProjectPage());
        }
    }
}