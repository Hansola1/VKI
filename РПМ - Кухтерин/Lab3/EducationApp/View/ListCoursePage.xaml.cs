using EducationApp.DataBase;
using EducationApp.Model;
using System.Windows;
using System.Windows.Controls;

namespace EducationApp.View
{
    public partial class ListCoursePage : Page
    {
        private CourseControllDB courseDB = new();

        public ListCoursePage()
        {
            InitializeComponent();
            LoadCourses();
        }

        private void LoadCourses()
        {
            List<Courses> listCourse = courseDB.GetCourses();
            Courses_ListView.ItemsSource = listCourse;
        }

        private void add_course_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AddCoursePage());
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MainMenuPage());
        }

        private void delete_course_Click(Object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Этого нет в тз))");
        }
    }
}
