using ElectricalProfiling.DataBase;
using System.Windows;
using System.Windows.Controls;

namespace ElectricalProfiling.Views.UseControll
{
    public partial class AddProject : UserControl
    {
        private ProjectControllerDB projectDB = new();

        public AddProject()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string name = ProjectName_TextBox.Text;
            string startDate = StartDate_Picker.Text;
            string customer = CustomerID_TextBox.Text; //теперь имя
            string endDate = EndDate_Picker.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(startDate) || string.IsNullOrEmpty(endDate) || string.IsNullOrEmpty(customer))
            {
                MessageBox.Show("Поля необходимо заполнить");
            }
            else
            {
                projectDB.AddProject(name, customer, startDate, endDate);
                MessageBox.Show("Проект сохранен!");

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
