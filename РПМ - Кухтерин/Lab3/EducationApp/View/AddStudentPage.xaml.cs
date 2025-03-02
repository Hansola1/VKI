using EducationApp.DataBase;
using System.Windows;
using System.Windows.Controls;

namespace EducationApp.View
{
    public partial class AddStudentPage : Page
    {
        private UserControllDB userDB = new();
        public AddStudentPage()
        {
            InitializeComponent();
        }

        private void add_student_Click(object sender, RoutedEventArgs e)
        {
            studentDataCheck();
        }

        private void studentDataCheck()
        {
            string name = Name_TextBox.Text;
            string login = Login_TextBox.Text;
            string password = Password_TextBox.Text;
            int roleID = 3;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Поля необходимо заполнить");
            }
            else 
            {
                userDB.AddUser(name, login, password, roleID);
                MessageBox.Show("Студент добавлен!");
            }
        }

        private void cancel_button_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MainMenuPage());
        }
        private void edit_student_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Этого нет в тз))))"); 
        }
    }
}
