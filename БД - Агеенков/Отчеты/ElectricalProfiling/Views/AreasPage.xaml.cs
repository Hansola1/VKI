using System.Windows;
using System.Windows.Controls;
using ElectricalProfiling.Views.UseControll;
using System.Windows.Media;
using ElectricalProfiling.Model.ViewModel;
using ElectricalProfiling.Model.DB;
using Microsoft.EntityFrameworkCore;
using ElectricalProfiling.Model;
using System.Windows.Shapes;

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
                        Name = area.Name,
                        Project = project != null ? project.Name : "Без проекта", //РЕШИТЬ ПРОБЛЕМУ. БЕЗ ПРОЕКТА
                        X = coordinate?.X ?? 0,
                        Y = coordinate?.Y ?? 0
                    };
                }).ToList();

                Area_DataGrid.ItemsSource = areas;
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
                editAreaControl.X_TextBox.Text = selectedArea.X.ToString();
                editAreaControl.Y_TextBox.Text = selectedArea.Y.ToString();
                editAreaControl.ProjectName_TextBox.Text = selectedArea.Project;
                MainGrid.Children.Add(editAreaControl);

                // Позиционируем UserControl по центру
                editAreaControl.HorizontalAlignment = HorizontalAlignment.Center;
                editAreaControl.VerticalAlignment = VerticalAlignment.Center;
            }
            else
            {
                MessageBox.Show("Выберите площадь для редактирования.");
            }
        }

        private List<AreaView> areas;
        public void LoadComboBox()
        {
            AreaSelector.ItemsSource = areas;
            AreaSelector.DisplayMemberPath = "Name";  // Для отображения только имени
            AreaSelector.SelectedValuePath = "Id";   // Для выбора по Id

            Area_DataGrid.ItemsSource = areas;
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
            // Очищаем старые элементы на Canvas
            AreaCanvas.Children.Clear();

            // Создаем новый элемент для отображения площади (например, круг)
            var ellipse = new Ellipse
            {
                Width = 20,
                Height = 20,
                Fill = Brushes.Blue
            };

            // Размещение по координатам X и Y
            Canvas.SetLeft(ellipse, area.X);
            Canvas.SetTop(ellipse, area.Y);

            // Добавляем элемент на Canvas
            AreaCanvas.Children.Add(ellipse);

            // Добавляем текстовое описание площади
            var textBlock = new TextBlock
            {
                Text = area.Name,
                Foreground = Brushes.Black
            };
            Canvas.SetLeft(textBlock, area.X + 25);
            Canvas.SetTop(textBlock, area.Y);

            // Добавляем текст на Canvas
            AreaCanvas.Children.Add(textBlock);
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
