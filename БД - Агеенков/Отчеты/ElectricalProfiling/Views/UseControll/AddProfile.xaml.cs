using ElectricalProfiling.Model.DB;
using ElectricalProfiling.Model;
using System.Windows;
using System.Windows.Controls;

namespace ElectricalProfiling.Views.UseControll
{
    public partial class AddProfile : UserControl
    {
        public AddProfile()
        {
            InitializeComponent();
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string nameProfile = ProfileName_TextBox.Text;
            string nameProject = ProjectName_TextBox.Text;
            string nameArea = AreaName_TextBox.Text;
            string xCoordinate = X_TextBox.Text;
            string yCoordinate = Y_TextBox.Text;

            if (string.IsNullOrWhiteSpace(nameProject) || string.IsNullOrWhiteSpace(nameProfile) ||
                string.IsNullOrWhiteSpace(nameArea) || string.IsNullOrWhiteSpace(xCoordinate) || string.IsNullOrWhiteSpace(yCoordinate))
            {
                MessageBox.Show("Все поля должны быть заполнены");
                return;
            }
            if (!double.TryParse(xCoordinate, out double x) || !double.TryParse(yCoordinate, out double y))
            {
                MessageBox.Show("Координаты X и Y должны быть числами");
                return;
            }

            string pointType = (PointType_ComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();
            if (string.IsNullOrEmpty(pointType))
            {
                MessageBox.Show("Выберите тип точки");
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

                var area = db.Area.FirstOrDefault(a => a.Name == nameArea);
                if (area == null)
                {
                    MessageBox.Show($"Площадь '{nameArea}' не найдена");
                    return;
                }

                var profile = new Profiles
                {
                    Area_ID = area.ID,
                    Name = nameProfile
                };
                db.Profile.Add(profile);
                db.SaveChanges();

                var profileCoordinate = new ProfileCoordinate
                {
                    Profile_ID = profile.ID,
                    X = x,
                    Y = y,
                    Point_Type = pointType  
                };
                db.ProfileCoordinate.Add(profileCoordinate);
                db.SaveChanges();

                MessageBox.Show("Профиль успешно создан");
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            var parent = Parent as Panel;
            parent?.Children.Remove(this);
        }
    }
}
