using ElectricalProfiling.DataBase;
using System.Windows;
using System.Windows.Controls;

namespace ElectricalProfiling.Views.UseControll
{
    public partial class EditProject : UserControl
    {
        private ProjectControllerDB projectDB = new();

        public EditProject()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string name = ProjectName_TextBox.Text;
            string startDate = StartDate_Picker.Text;
            string endDate = EndDate_Picker.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(startDate) || string.IsNullOrEmpty(endDate))
            {
                MessageBox.Show("Поля необходимо заполнить");
            }
            else
            {
                projectDB.EditProject(name, startDate, endDate);
                MessageBox.Show("Проект изменен!");

                ProjectPage project = new();
                project.LoadProject();
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            var parent = Parent as Panel;
            parent?.Children.Remove(this);
        }
    }
}
