using ElectricalProfiling.Model.DB;
using ElectricalProfiling.Model.ViewModel;
using ElectricalProfiling.Views.UseControll;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using LiveCharts;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ElectricalProfiling.Views
{
    public partial class ProfilePage : Page
    {
        public ProfilePage()
        {
            InitializeComponent();
            LoadProfile();
            LoadComboBox();
        }


        public void LoadProfile()
        {
            using (var db = new ApplicationContext())
            {
                this.profiles = db.Profile.ToList()
                    .Select(profile =>
                    {
                        var area = db.Area.FirstOrDefault(a => a.ID == profile.Area_ID);
                        var project = area != null ? db.Project.FirstOrDefault(p => p.Id == area.Project_ID) : null;
                        var coordinate = db.ProfileCoordinate.FirstOrDefault(c => c.Profile_ID == profile.ID && c.Point_Type == "start");

                        return new ProfileView
                        {
                            Name = profile.Name,
                            Project = project?.Name ?? "Без проекта",
                            Area = area?.Name ?? "Без площади",
                            X = coordinate?.X ?? 0,
                            Y = coordinate?.Y ?? 0
                        };
                    }).ToList();

                Profile_DataGrid.ItemsSource = this.profiles;
            }
        }


        private void DeleteProfile_Click(object sender, RoutedEventArgs e)
        {
            var selectedProfile = Profile_DataGrid.SelectedItem as ProfileView;
            if (selectedProfile != null)
            {
                using (var db = new ApplicationContext())
                {
                    var profileToDelete = db.Profile.FirstOrDefault(p => p.Name == selectedProfile.Name);
                    if (profileToDelete != null)
                    {
                        var coordinates = db.ProfileCoordinate.Where(c => c.Profile_ID == profileToDelete.ID);
                        db.ProfileCoordinate.RemoveRange(coordinates);

                        db.Profile.Remove(profileToDelete);
                        db.SaveChanges();

                        MessageBox.Show("Профиль успешно удалён!");
                        LoadProfile();
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите профиль для удаления");
            }
        }

        private void EditProfile_Click(Object sender, RoutedEventArgs e)
        {
            var selectedProfile = Profile_DataGrid.SelectedItem as ProfileView;
            if (selectedProfile != null)
            {
                var editProfileControl = new EditProfile();

                editProfileControl.ProfileName_TextBox.Text = selectedProfile.Name;
                editProfileControl.AreaName_TextBox.Text = selectedProfile.Area;
                editProfileControl.X_TextBox.Text = selectedProfile.X.ToString();
                editProfileControl.Y_TextBox.Text = selectedProfile.Y.ToString();
                editProfileControl.ProjectName_TextBox.Text = selectedProfile.Project;
                MainGrid.Children.Add(editProfileControl);

                // Позиционируем UserControl по центру
                editProfileControl.HorizontalAlignment = HorizontalAlignment.Center;
                editProfileControl.VerticalAlignment = VerticalAlignment.Center;
            }
            else
            {
                MessageBox.Show("Выберите профиль для редактирования.");
            }
        }

        private void AddProfile_Click(object sender, RoutedEventArgs e)
        {
            var addAreaControl = new AddProfile();
            MainGrid.Children.Add(addAreaControl);

            addAreaControl.HorizontalAlignment = HorizontalAlignment.Center;
            addAreaControl.VerticalAlignment = VerticalAlignment.Center;
        }

        private List<ProfileView> profiles;
        public void LoadComboBox()
        {
            ProfileSelector.ItemsSource = profiles;
            ProfileSelector.DisplayMemberPath = "Name";  // Для отображения только имени
            ProfileSelector.SelectedValuePath = "Id";   // Для выбора по Id

            Profile_DataGrid.ItemsSource = profiles;
        }

        private void ProfileSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ProfileSelector.SelectedItem is ProfileView selectedProfile)
            {
                DrawProfile(selectedProfile);
            }
        }

        private void DrawProfile(ProfileView profileView)
        {
            if (ProfileChart == null)
            {
                MessageBox.Show("ProfileChart ещё не инициализирован.");
                return;
            }

            using (var db = new ApplicationContext())
            {
                // Ищем профиль по имени
                var profile = db.Profile.FirstOrDefault(p => p.Name == profileView.Name);
                if (profile == null)
                {
                    MessageBox.Show("Профиль не найден.");
                    return;
                }

                // Получаем координаты профиля
                var coordinates = db.ProfileCoordinate
                    .Where(c => c.Profile_ID == profile.ID)
                    .OrderBy(c => c.ID) // Сортируем по ID, чтобы построить кривую по порядку
                    .Select(c => new ObservablePoint(c.X, c.Y)) // Преобразуем в ObservablePoint для LiveCharts
                    .ToList();

                if (coordinates.Count == 0)
                {
                    MessageBox.Show("Нет координат для выбранного профиля.");
                    return;
                }

                // Создаем LineSeries для отображения кривой
                var lineSeries = new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>(coordinates), // Передаем координаты
                    PointGeometry = null, // Отключаем отображение точек на графике
                    StrokeThickness = 2, // Толщина линии
                    Fill = System.Windows.Media.Brushes.Transparent, // Прозрачный фон
                    LineSmoothness = 0.2 // Устанавливаем сглаживание линии (по желанию)
                };

                // Очищаем текущие серии перед добавлением новой
                ProfileChart.Series.Clear();

                // Добавляем созданную серию на график
                ProfileChart.Series.Add(lineSeries);
            }
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
