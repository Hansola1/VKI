using ElectricalProfiling.Model.DB;
using ElectricalProfiling.Model;
using System.Windows;
using System.Windows.Controls;

namespace ElectricalProfiling.Views.UseControll
{
    public partial class AddStation : UserControl
    {
        public AddStation()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string stationName = NameStation_TextBox.Text;
            string profileTitle = Profile_TextBox.Text;
            string coodinates = Coordinates_TextBox.Text;
            string elevation = Elevation_TextBox.Text;

            if (string.IsNullOrWhiteSpace(profileTitle) || string.IsNullOrWhiteSpace(coodinates) || string.IsNullOrWhiteSpace(elevation) || string.IsNullOrWhiteSpace(stationName))
            {
                MessageBox.Show("Все поля должны быть заполнены");
                return;
            }

            using (var db = new ApplicationContext())
            {
                var profile = db.Profile.FirstOrDefault(p => p.Name == profileTitle);
                if (profile == null)
                {
                    MessageBox.Show($"Профиль '{profileTitle}' не найден");
                    return;
                }

                var stations = new Stations
                {
                    station_name = stationName,
                    Profile_ID = profile.ID,
                    Coordinates = coodinates,
                    Elevation = Convert.ToDouble(elevation)
                };
                db.Stations.Add(stations);
                db.SaveChanges();

                MessageBox.Show("Станция успешно создана");
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            var parent = Parent as Panel;
            parent?.Children.Remove(this);
        }
    }
}
