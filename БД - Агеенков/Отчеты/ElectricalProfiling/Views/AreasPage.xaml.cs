using System.Windows;
using System.Windows.Controls;
using ElectricalProfiling.Views.UseControll;
using System.Windows.Media;
using ElectricalProfiling.Model.ViewModel;
using ElectricalProfiling.Model.DB;
using ElectricalProfiling.Model;
using Microsoft.EntityFrameworkCore;
using System.Reflection.PortableExecutable;
using System.Windows.Data;

namespace ElectricalProfiling.Views
{
    public partial class AreasPage : Page
    {
        public AreasPage()
        {
            InitializeComponent();
            LoadArea();
        }
        public void LoadArea()
        {
            using (var db = new ApplicationContext())
            {
                var listArea = db.Area.Select(area => new AreaView
                {
                    Name = area.Name,
                    Project = db.Project.FirstOrDefault(p => p.Id == area.Project_ID).Name,
                    X = db.AreaCoordinate.FirstOrDefault(c => c.area_ID == area.ID).X.ToString(),
                    Y = db.AreaCoordinate.FirstOrDefault(c => c.area_ID == area.ID).Y.ToString()
                }).ToList();

                Area_DataGrid.ItemsSource = listArea;
            }
        } //очень важно создать класс для визуализации DataGrid(AreaView)

        private void AddArea_Click(object sender, RoutedEventArgs e)
        {
            var addAreaControl = new AddArea();
            MainGrid.Children.Add(addAreaControl);

            addAreaControl.HorizontalAlignment = HorizontalAlignment.Center;
            addAreaControl.VerticalAlignment = VerticalAlignment.Center;
        }

        private void DeleteArea_Click(object sender, RoutedEventArgs e)
        {
            var selectedArea = Area_DataGrid.SelectedItem as AreaView;
            if (selectedArea != null)
            {
                using (var db = new ApplicationContext())
                {
                    var areaToDelete = db.Area.FirstOrDefault(a => a.Name == selectedArea.Name);
                    if (areaToDelete != null)
                    {
                        var coordinates = db.AreaCoordinate.Where(c => c.area_ID == areaToDelete.ID);
                        db.AreaCoordinate.RemoveRange(coordinates);

                        db.Area.Remove(areaToDelete);
                        db.SaveChanges();

                        MessageBox.Show("Площадь успешно удалена!");
                        LoadArea();
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите площадь для удаления");
            }
        }

        private void EditArea_Click(object sender, RoutedEventArgs e)
        {
            var selectedArea = Area_DataGrid.SelectedItem as AreaView;
            if (selectedArea != null)
            {
                var editAreaControl = new EditArea();

                editAreaControl.AreaName_TextBox.Text = selectedArea.Name;
                editAreaControl.X_TextBox.Text = selectedArea.X;
                editAreaControl.Y_TextBox.Text = selectedArea.Y;
                editAreaControl.ProjectName_TextBox.Text = selectedArea.Project;
                MainGrid.Children.Add(editAreaControl);

                // Позиционируем UserControl по центру
                editAreaControl.HorizontalAlignment = HorizontalAlignment.Center;
                editAreaControl.VerticalAlignment = VerticalAlignment.Center;
            }
            else
            {
                MessageBox.Show("Выберите проект для редактирования.");
            }
        }


        private string _placeholderText = "Поиск площади";
        private void Find_TextBox_GotFocus(object sender, RoutedEventArgs e)
        {        
            Find_TextBox.Text = "";
            Find_TextBox.Foreground = Brushes.Black;
        }

        private void Find_TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Find_TextBox.Text))
            {
                Find_TextBox.Text = _placeholderText;
                Find_TextBox.Foreground = new SolidColorBrush(Color.FromRgb(0x15, 0x32, 0x5B));
            }
        }

        private void Find_TextBox_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            string searchText = Find_TextBox.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                LoadArea();
            }
            else
            {
                FilterAreas(searchText);
            }
        }

        private async void FilterAreas(string searchText)
        {
            using (var db = new ApplicationContext())
            {
                var filteredAreas = await db.Area
                    .Where(area => area.Name.Contains(searchText) ||
                            db.Project.Any(p => p.Id == area.Project_ID && p.Name.Contains(searchText)))
                    .Select(area => new AreaView
                    {
                        Name = area.Name,
                        Project = db.Project.FirstOrDefault(p => p.Id == area.Project_ID).Name,
                        X = db.AreaCoordinate.FirstOrDefault(c => c.area_ID == area.ID).X.ToString(),
                        Y = db.AreaCoordinate.FirstOrDefault(c => c.area_ID == area.ID).Y.ToString()
                    })
                    .ToListAsync();

                Area_DataGrid.ItemsSource = filteredAreas;
            }
        }

        private void Out_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void OpenArea_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AreasPage());
        }
        private void OpenProject_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProjectPage());
        }
        private void OpenProfile_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProfilePage());
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
