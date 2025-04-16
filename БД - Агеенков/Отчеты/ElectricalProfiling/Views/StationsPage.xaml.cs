using ElectricalProfiling.Model.DB;
using ElectricalProfiling.Model.ViewModel;
using ElectricalProfiling.Views.UseControll;
using System.Windows;
using System.Windows.Controls;

namespace ElectricalProfiling.Views
{
    public partial class StationsPage : Page
    {
        public StationsPage()
        {
            InitializeComponent();
            LoadStantion();
        }

        public void LoadStantion()
        {
            using (var db = new ApplicationContext())
            {
                var stations = db.Profile.ToList()
                    .Select(profile =>
                    {
                        var area = db.Area.FirstOrDefault(a => a.ID == profile.Area_ID);
                        var project = area != null ? db.Project.FirstOrDefault(p => p.Id == area.Project_ID) : null;
                        var coordinate = db.ProfileCoordinate.FirstOrDefault(c => c.Profile_ID == profile.ID && c.Point_Type == "start");

                        var station = db.Stations.FirstOrDefault(s => s.Profile_ID == profile.ID);

                        return new StationView
                        {
                            StationNames = station != null ? station.station_name : "Неизвестно",  
                            ProfileName = profile.Name,
                            Coordinates = coordinate != null ? $"{coordinate.X}, {coordinate.Y}" : "Неизвестно",
                            Elevation = station != null ? station.Elevation : 0 
                        };
                    }).ToList();

                Stations_DataGrid.ItemsSource = stations;
            }
        }

        private void DeleteStation_Click(object sender, RoutedEventArgs e)
        {
            var selectedStation = Stations_DataGrid.SelectedItem as StationView;
            if (selectedStation != null)
            {
                using (var db = new ApplicationContext())
                {
                    // Ищем станцию по имени профиля
                    var profile = db.Profile.FirstOrDefault(p => p.Name == selectedStation.ProfileName);
                    if (profile != null)
                    {
                        // Ищем соответствующую станцию
                        var stationToDelete = db.Stations.FirstOrDefault(s => s.Profile_ID == profile.ID);
                        if (stationToDelete != null)
                        {
                            db.Stations.Remove(stationToDelete);
                            db.SaveChanges();

                            MessageBox.Show("Станция успешно удалена!");
                            LoadStantion(); 
                        }
                        else
                        {
                            MessageBox.Show("Станция не найдена.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Профиль для этой станции не найден.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите станцию для удаления.");
            }
        }


        private void AddStation_Click(object sender, RoutedEventArgs e)
        {
            var addAreaControl = new AddStation();
            MainGrid.Children.Add(addAreaControl);

            addAreaControl.HorizontalAlignment = HorizontalAlignment.Center;
            addAreaControl.VerticalAlignment = VerticalAlignment.Center;
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
