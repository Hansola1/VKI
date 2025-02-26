using EducationApp.DataBase;
using System.Windows;
using System.Windows.Controls;

namespace EducationApp.View
{
    public partial class LoginPage : Page
    {
        private UserControllDB userDB = new();

        public LoginPage()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (LogDataCheck())
            {
                MainFrame.Navigate(new MainMenuPage());
            }
        }

        private bool LogDataCheck()
        {
            string login = Login_TextBox.Text;
            string password = Password_TextBox.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Поля необходимо заполнить");
                return false;
            }
            else if (userDB.dateVerification(login, password) == true)
            {
                MessageBox.Show("Вы успешно авторизовались");
                return true;
            }
            else if (userDB.dateVerification(login, password) == false)
            {
                MessageBox.Show("Аккаунт не найден");
                return false;
            }
            return false;
        }
    }
}
