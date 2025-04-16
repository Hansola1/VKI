using ElectricalProfiling.Model;
using ElectricalProfiling.Model.DB;
using System.Windows;
using System.Windows.Controls;

namespace ElectricalProfiling.Views.UseControll
{
    public partial class AddArea : UserControl
    {
        public AddArea()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string nameProject = ProjectName_TextBox.Text;
                string nameArea = AreaName_TextBox.Text;
                string xCoordinate = X_TextBox.Text;
                string yCoordinate = Y_TextBox.Text;

                if (string.IsNullOrWhiteSpace(nameProject) || string.IsNullOrWhiteSpace(nameArea) || string.IsNullOrWhiteSpace(xCoordinate) || string.IsNullOrWhiteSpace(yCoordinate))
                {
                    MessageBox.Show("Все поля должны быть заполнены");
                    return;
                }
                if (!int.TryParse(xCoordinate, out int x) || !int.TryParse(yCoordinate, out int y))
                {
                    MessageBox.Show("Координаты должны быть целыми числами");
                    return;
                }

                using (var db = new ApplicationContext())
                {
                    var project = db.Project.FirstOrDefault(p => p.Name == nameProject);
                    if (project == null)
                    {
                        MessageBox.Show($"Проект '{nameProject}' не найден");
                        return;
                    }
                    var area = new Areas
                    {
                        Name = nameArea,
                        Project_ID = project.Id
                    };

                    db.Area.Add(area);
                    db.SaveChanges();

                    var areaCoordinate = new AreaCoordinate
                    {
                        area_ID = area.ID,
                        X = x,
                        Y = y
                    };
                    db.AreaCoordinate.Add(areaCoordinate);
                    db.SaveChanges();

                    MessageBox.Show("Площадь успешно создана");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}");
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            var parent = Parent as Panel;
            parent?.Children.Remove(this);
        }
    }
}