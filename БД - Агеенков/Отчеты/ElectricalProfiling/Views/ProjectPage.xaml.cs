using ElectricalProfiling.DataBase;
using ElectricalProfiling.Model;
using ElectricalProfiling.Views.UseControll;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace ElectricalProfiling.Views
{
    public partial class ProjectPage : Page
    {
        private ProjectControllerDB projectDB = new();
        public ProjectPage()
        {
            InitializeComponent();
           // LoadProject();
        }
        private void Open_Area_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AreasPage());
        }

        private void LoadProject()
        {
            //List<Projects> listProject = projectDB.GetProject();
           // Projects_DataGrid.ItemsSource = listProject;
        }

        private void Add_Project_Click(object sender, RoutedEventArgs e)
        {
            var addProjectControl = new AddProject();
            MainGrid.Children.Add(addProjectControl);

            // Позиционируем UserControl по центру
            addProjectControl.HorizontalAlignment = HorizontalAlignment.Center;
            addProjectControl.VerticalAlignment = VerticalAlignment.Center;
        }

        private void Out_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
