using EducationPlans.Model.DataBase;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace EducationPlans.View
{
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void loginClick(object sender, RoutedEventArgs e)
        {
            if (validationData())
            {
                if (loginUserDB())
                {
                    string typeUser = checkTypeUser();

                    UserSession.IsLoggedIn = true;
                    UserSession.typeUser = typeUser;
                    UserSession.CurrentUserLogin = loginTextBox.Text;
                    MainFrame.Navigate(new HomeworkPage());
                }
            }
        }

        private bool validationData()
        {
            string name = nameTextBox.Text;
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            string specialization = specializationTextBox.Text;
            string group = groupTextBox.Text;

            if (string.IsNullOrWhiteSpace(name) || name == "Имя" || string.IsNullOrWhiteSpace(login) || login == "Логин" || string.IsNullOrWhiteSpace(password) || password == "Пароль")
            {
                MessageBox.Show("Пожалуйста, заполните все поля корректно.", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }
            return true;
        }

        private bool loginUserDB()
        {
            using (var db = new ApplicationContext())
            {
                string typeUser = checkTypeUser();
                string login = loginTextBox.Text;
                string password = passwordTextBox.Text;

                if (typeUser == "student")
                {
                    var student = db.Student.FirstOrDefault(p => p.Login == login && p.Password == password);
                    if (student == null)
                    {
                        MessageBox.Show("Неверный логин или пароль для студента.", "Ошибка входа", MessageBoxButton.OK, MessageBoxImage.Error);
                        return false;
                    }

                    MessageBox.Show($"Добро пожаловать, студент {student.Name}!");
                    return true;
                }
                else if (typeUser == "teacher")
                {
                    var teacher = db.Teacher.FirstOrDefault(p => p.Login == login && p.Password == password);
                    if (teacher == null)
                    {
                        MessageBox.Show("Неверный логин или пароль для преподавателя.", "Ошибка входа", MessageBoxButton.OK, MessageBoxImage.Error);
                        return false;
                    }

                    MessageBox.Show($"Добро пожаловать, преподаватель {teacher.Name}!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Не удалось определить тип пользователя.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return false;
                }
            }
        }

        private string checkTypeUser()
        {
            string specialization = specializationTextBox.Text;
            string group = groupTextBox.Text;

            if (string.IsNullOrWhiteSpace(specialization) || specialization == "Специализация")
            {
                return "student";
            }
            if (string.IsNullOrWhiteSpace(group) || group == "Группа")
            {
                return "teacher";
            }
            if (string.IsNullOrWhiteSpace(specialization) || specialization == "Специализация" || string.IsNullOrWhiteSpace(group) || group == "Группа")
            {
                return "none";
            }
            return "none";
        }

        private void TextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            nameTextBox.Foreground = Brushes.Black;
        }
    }
}
