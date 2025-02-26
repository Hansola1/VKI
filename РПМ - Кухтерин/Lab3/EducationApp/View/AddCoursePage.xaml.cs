using EducationApp.DataBase;
using System.Windows;
using System.Windows.Controls;

namespace EducationApp.View
{
    public partial class AddCoursePage : Page
    {
        CourseControllDB courseDB = new();
        public AddCoursePage()
        {
            InitializeComponent();
        }

        private void add_course_Click(object sender, RoutedEventArgs e)
        {
            courseDataCheck();
        }

        private void courseDataCheck()
        {
            string titleCourse = Title_Course_TextBox.Text;
            string nameTeacher = Name_Teacher_TextBox.Text;
            string timeCourse = Time_Course_TextBox.Text;
            string maxStudents = MaxStudents_TextBox.Text;
            string classCourse = Class_TextBox.Text;

            if (string.IsNullOrEmpty(titleCourse) || string.IsNullOrEmpty(nameTeacher) || string.IsNullOrEmpty(timeCourse) || string.IsNullOrEmpty(maxStudents) || string.IsNullOrEmpty(classCourse))
            {
                MessageBox.Show("Все поля необходимо заполнить");
            }
            else
            {
                int teacherID = courseDB.GetTeacherID(nameTeacher);
                if (teacherID != -1)
                {
                    if (!courseDB.CourseExists(titleCourse))
                    {
                        courseDB.AddCourse(titleCourse, teacherID, timeCourse, maxStudents, classCourse);
                        MessageBox.Show("Курс добавлен!");
                    }
                    else
                    {
                        MessageBox.Show("Такой курс существует");
                    }
                }
                else
                {
                    MessageBox.Show("Преподаватель не найден");
                }
            }
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MainMenuPage());
        }
    }
}
