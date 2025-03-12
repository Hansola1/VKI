using System.Windows;
using System.Windows.Controls;

namespace ElectricalProfiling.Views
{
    public partial class AreasPage : Page
    {
        public AreasPage()
        {
            InitializeComponent();
        }

        private void Open_Project_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProjectPage());
        }
        private void Add_Area_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Out_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
