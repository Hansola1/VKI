using ElectricalProfiling.Model.DB;
using ElectricalProfiling.Model;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ElectricalProfiling.Views.UseControll
{
    public partial class AddProfile : UserControl
    {
        public AddProfile()
        {
            InitializeComponent();
            LoadProjects();
        }

        private void LoadProjects()
        {
            using (var db = new ApplicationContext())
            {
                ProjectComboBox.ItemsSource = db.Project.ToList();
                ProjectComboBox.DisplayMemberPath = "Name";
                ProjectComboBox.SelectedValuePath = "Id";
            }
        }

        private void ProjectComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ProjectComboBox.SelectedValue is int projectId)
            {
                using (var db = new ApplicationContext())
                {
                    var areas = db.Area.Where(a => a.Project_ID == projectId).ToList();
                    AreaComboBox.ItemsSource = areas;
                    AreaComboBox.DisplayMemberPath = "Name";
                    AreaComboBox.SelectedValuePath = "ID";
                }
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string nameProfile = ProfileName_TextBox.Text;
            string xCoordinate = X_TextBox.Text;
            string yCoordinate = Y_TextBox.Text;

            if (ProjectComboBox.SelectedValue == null || AreaComboBox.SelectedValue == null ||
                string.IsNullOrWhiteSpace(nameProfile) || string.IsNullOrWhiteSpace(xCoordinate) || string.IsNullOrWhiteSpace(yCoordinate))
            {
                MessageBox.Show("Все поля должны быть заполнены, включая проект и площадь");
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

            int areaId = (int)AreaComboBox.SelectedValue;

            using (var db = new ApplicationContext())
            {
                var profile = new Profiles
                {
                    Area_ID = areaId,
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
