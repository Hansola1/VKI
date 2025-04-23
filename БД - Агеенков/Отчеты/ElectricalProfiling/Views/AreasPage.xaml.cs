using ElectricalProfiling.Model;
using ElectricalProfiling.Model.DB;
using ElectricalProfiling.Model.ViewModel;
using ElectricalProfiling.Views.UseControll;
using LiveCharts.Wpf;
using LiveCharts;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ElectricalProfiling.Views
{
    public partial class AreasPage : Page
    {
        public AreasPage()
        {
            InitializeComponent();
            LoadArea();
            LoadComboBox();
        }

        private List<AreaView> areas;

        public void LoadArea()
        {
            using (var db = new ApplicationContext())
            {
                areas = db.Area.ToList()
                .Select(area =>
                {
                    var project = db.Project.FirstOrDefault(p => p.Id == area.Project_ID);
                    var coordinate = db.AreaCoordinate.FirstOrDefault(c => c.area_ID == area.ID);

                    return new AreaView
                    {
                        Id = area.ID,
                        Name = area.Name,
                        Project = project != null ? project.Name : "Без проекта",
                        X = coordinate?.X ?? 0,
                        Y = coordinate?.Y ?? 0
                    };
                }).ToList();

                Area_DataGrid.ItemsSource = areas;
            }
        }

        public void LoadComboBox()
        {
            AreaSelector.ItemsSource = areas;
            AreaSelector.DisplayMemberPath = "Name";
            AreaSelector.SelectedValuePath = "Id";
        }

        private void AreaSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AreaSelector.SelectedItem is AreaView selectedArea)
            {
                DrawArea(selectedArea);
            }
        }

        private void DrawArea(AreaView area)
        {
            var rand = new Random();
            int pointCount = rand.Next(5, 10);

            var points = new List<LiveCharts.Defaults.ObservablePoint>();

            for (int i = 0; i < pointCount; i++)
            {
                double angle = 2 * Math.PI * i / pointCount;
                double radius = rand.Next(50, 150);
                double x = radius * Math.Cos(angle);
                double y = radius * Math.Sin(angle);
                points.Add(new LiveCharts.Defaults.ObservablePoint(x, y));
            }

            if (points.Count > 0)
            {
                points.Add(new LiveCharts.Defaults.ObservablePoint(points[0].X, points[0].Y));
            }

            AreaChart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<LiveCharts.Defaults.ObservablePoint>(points),
                    PointGeometry = DefaultGeometries.Circle,
                    Fill = new SolidColorBrush(Color.FromArgb(50, 100, 149, 237)),
                    StrokeThickness = 2,
                    LineSmoothness = 0,
                    Title = area.Name
                }
            };

            AreaChart.AxisX.Clear();
            AreaChart.AxisY.Clear();
            AreaChart.AxisX.Add(new Axis { Title = "X" });
            AreaChart.AxisY.Add(new Axis { Title = "Y" });
        }

        private void AddArea_Click(object sender, RoutedEventArgs e)
        {
            var addAreaControl = new AddArea();
            MainGrid.Children.Add(addAreaControl);

            addAreaControl.HorizontalAlignment = HorizontalAlignment.Center;
            addAreaControl.VerticalAlignment = VerticalAlignment.Center;
        }

        private void DeleteArea_Click(object sender, RoutedEventArgs e)
        {
            if (Area_DataGrid.SelectedItem is AreaView selectedArea)
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
                        LoadComboBox();
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
            if (Area_DataGrid.SelectedItem is AreaView selectedArea)
            {
                var editAreaControl = new EditArea();

                editAreaControl.AreaName_TextBox.Text = selectedArea.Name;
                editAreaControl.X_TextBox.Text = selectedArea.X.ToString();
                editAreaControl.Y_TextBox.Text = selectedArea.Y.ToString();
                editAreaControl.ProjectName_TextBox.Text = selectedArea.Project;
                MainGrid.Children.Add(editAreaControl);

                editAreaControl.HorizontalAlignment = HorizontalAlignment.Center;
                editAreaControl.VerticalAlignment = VerticalAlignment.Center;
            }
            else
            {
                MessageBox.Show("Выберите площадь для редактирования.");
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
                        X = db.AreaCoordinate.FirstOrDefault(c => c.area_ID == area.ID).X,
                        Y = db.AreaCoordinate.FirstOrDefault(c => c.area_ID == area.ID).Y
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
