using EducationApp.DataBase;
using EducationApp.Model;
using System.Windows;
using System.Windows.Controls;

namespace EducationApp.View
{
    public partial class AddTeacherPage : Page
    {
        private UserControllDB userDB = new();
        public AddTeacherPage()
        {
            InitializeComponent();
        }

        private void cancel_button_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MainMenuPage());
        }

        private void add_teacher_Click(object sender, RoutedEventArgs e)
        {
            teacherDataCheck();
        }

        private void teacherDataCheck()
        {
            string name = Name_TextBox.Text;
            string login = Login_TextBox.Text;
            string password = Password_TextBox.Text;
            int roleID = 2;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Поля необходимо заполнить");
            }
            else
            {
                userDB.AddUser(name, login, password, roleID);
                MessageBox.Show("Преподаватель добавлен!");
            }
        }

        private void edit_teacher_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Этого нет в тз))))");
        }
    }
}

