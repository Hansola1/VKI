using ElectricalProfiling.Views.UseControll;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ElectricalProfiling.Views
{
    public partial class MeasurementsPage : Page
    {
        public MeasurementsPage()
        {
            InitializeComponent();
        }

        private void AddMeasurement_Click(object sender, RoutedEventArgs e)
        {
            var addMeasurementsControl = new AddMeasurements();
            MainGrid.Children.Add(addMeasurementsControl);

            addMeasurementsControl.HorizontalAlignment = HorizontalAlignment.Center;
            addMeasurementsControl.VerticalAlignment = VerticalAlignment.Center;
        }

        private void DeleteMeasurement_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Out_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void OpenProject_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProjectPage());
        }
        private void OpenProfile_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProfilePage());
        }
        private void OpenArea_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AreasPage());
        }
        private void OpenStations_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new StationsPage());
        }
        private void OpenMeasurements_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MeasurementsPage());
        }
    }
}
