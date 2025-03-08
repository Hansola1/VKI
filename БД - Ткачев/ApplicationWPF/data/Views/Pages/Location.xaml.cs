using data.DataBase;
using data.Model;
using System.Windows;
using System.Windows.Controls;

namespace data.Views.Pages
{
    public partial class Location : Page
    {
        private LocationControllDB LocationDB = new();
        public Location()
        {
            InitializeComponent();
            loadBiomeComboBox();
            Biome_ComboBox.SelectionChanged += Biome_ComboBox_SelectionChanged; 
        }
        private void loadBiomeComboBox()
        {
            List<Locations> biomes = LocationDB.GetBiomeComboBox();

            Biome_ComboBox.ItemsSource = biomes;
            Biome_ComboBox.DisplayMemberPath = "Biome"; //отображаем только биомы
        }

        private void Biome_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) 
        {
            LoadLocationAndEnemies(); // Загружаем локации ТОЛЬКО при изменении выбора
        }

        private void LoadLocationAndEnemies()
        {
            var selectedBiome = Biome_ComboBox.SelectedItem as Locations; // нагло поменяем тип

            if (selectedBiome != null)
            {
                string biome = selectedBiome.Biome; 
                List<Locations> location = LocationDB.GetInfoLocation(biome);
                Location_ListView.ItemsSource = location;

                int locationID = LocationDB.GetLocationID(biome);
                List<Enemies> enemies = LocationDB.GetEnemiesForLocations(locationID);
                Enemies_ListView.ItemsSource = enemies;
            }
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Profile());
        }
    }
}
