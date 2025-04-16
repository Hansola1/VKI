using ElectricalProfiling.DataBase;
using ElectricalProfiling.Model;
using ElectricalProfiling.Views.UseControll;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ElectricalProfiling.Views
{
    public partial class ProjectPage : Page
    {
        private ProjectControllerDB projectDB = new();
        public ProjectPage()
        {
            InitializeComponent();
            LoadProject();
        }

        public void LoadProject()
        {
            List<Projects> listProject = projectDB.GetProject();
            Projects_DataGrid.ItemsSource = listProject;
        }

        private void Add_Project_Click(object sender, RoutedEventArgs e)
        {
            var addProjectControl = new AddProject();
            MainGrid.Children.Add(addProjectControl);

            // Позиционируем UserControl по центру
            addProjectControl.HorizontalAlignment = HorizontalAlignment.Center;
            addProjectControl.VerticalAlignment = VerticalAlignment.Center;
        }

        private void Find_TextBox_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            string findTextBox = Find_TextBox.Text;

            if (string.IsNullOrEmpty(findTextBox))
            {
                LoadProject();
            }
            else
            {
                FilterProjects(findTextBox);
            }
        }

        private string _placeholderText = "Поиск проекта"; 
        private void Find_TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Find_TextBox.Text == _placeholderText)
            {
                Find_TextBox.Text = "";
                Find_TextBox.Foreground = Brushes.Black; 
            }
        }
        private void Find_TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Find_TextBox.Text))
            {
                Find_TextBox.Text = _placeholderText;
                Find_TextBox.Foreground = new SolidColorBrush(Color.FromRgb(0x15, 0x32, 0x5B)); // Восстанавливаем цвет
            }
        }

        private void FilterProjects(string searchText)
        {
            // Фильтрация проектов по введённому тексту
            List<Projects> filteredProjects = projectDB.GetProject()
                .Where(project => project.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                .ToList();

            Projects_DataGrid.ItemsSource = filteredProjects;
        }

        private void Edit_Project_Click(object sender, RoutedEventArgs e)
        {
            var selectedProject = Projects_DataGrid.SelectedItem as Projects;
            if (selectedProject != null)
            {
                var editProjectControl = new EditProject();

                editProjectControl.ProjectName_TextBox.Text = selectedProject.Name;
                editProjectControl.StartDate_Picker.SelectedDate = selectedProject.Start_date;
                editProjectControl.EndDate_Picker.SelectedDate = selectedProject.End_date;
                MainGrid.Children.Add(editProjectControl);

                // Позиционируем UserControl по центру
                editProjectControl.HorizontalAlignment = HorizontalAlignment.Center;
                editProjectControl.VerticalAlignment = VerticalAlignment.Center;
            }
            else
            {
                MessageBox.Show("Выберите проект для редактирования.");
            }
        }

        private void Delete_Project_Click(object sender, RoutedEventArgs e)
        {
            var selectedProject = Projects_DataGrid.SelectedItem as Projects;
            if (selectedProject != null)
            {
                string name = selectedProject.Name;
                projectDB.DeleteProject(name);
                MessageBox.Show("Проект удален!");

                LoadProject();
            }
            else
            {
                MessageBox.Show("Выберите проект для удаления");
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
