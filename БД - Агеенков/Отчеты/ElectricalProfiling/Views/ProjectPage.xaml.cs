using System.Windows;
using System.Windows.Controls;

namespace ElectricalProfiling.Views
{
    public partial class ProjectPage : Page
    {
        public ProjectPage()
        {
            InitializeComponent();
        }

        private void Open_Area_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AreasPage());
        }

        private void Add_Project_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Out_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
