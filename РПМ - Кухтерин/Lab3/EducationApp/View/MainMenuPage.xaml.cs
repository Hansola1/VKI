using System.Windows;
using System.Windows.Controls;

namespace EducationApp.View
{
    public partial class MainMenuPage : Page
    {
        public MainMenuPage()
        {
            InitializeComponent();
        }
        private void add_student_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AddStudentPage());
        }
        private void list_request_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListRequest());
        }
        private void add_teacher_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AddTeacherPage());
        }
        private void course_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListCoursePage());
        }
    }
}
