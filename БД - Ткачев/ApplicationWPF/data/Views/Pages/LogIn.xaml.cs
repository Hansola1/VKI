using System.Windows;
using System.Windows.Controls;
using data.DataBase;
using data.Model;
using data.Views.Pages;

namespace data.Views.Pages
{
    public partial class LogIn : Page
    {
        private UserControllDB userDB = new();

        public LogIn()
        {
            InitializeComponent();
        }

        public void reg_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Registration());
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            string login = login_TextBox.Text;
            string password = password_TextBox.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            { 
                MessageBox.Show("Поля необходимо заполнить");
                return;
            }
            else
            {
                if (userDB.dateVerification(login, password))
                {
                    UserSession.IsLoggedIn = true;
                    UserSession.CurrentUserLogin = login_TextBox.Text.Trim();

                    MessageBox.Show($"Вход выполнен!");
                    MainFrame.Navigate(new Profile());
                }
                else 
                {
                    MessageBox.Show($"Пользователя не существует :(");
                }
            }
        }
    }
}
