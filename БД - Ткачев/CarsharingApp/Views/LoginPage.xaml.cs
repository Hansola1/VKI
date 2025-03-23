using CarsharingApp.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CarsharingApp.Views
{
    public partial class LoginPage : Page
    {
        private DB_UsersController dbUsers = new();
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            string login = Login_TextBox.Text;
            string password = Password_TextBox.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Поля необходимо заполнить");
                return;
            }
            else
            {
                if (dbUsers.dateVerification(login, password))
                {
                    UserSession.IsLoggedIn = true;
                    UserSession.CurrentUserLogin = Login_TextBox.Text.Trim();

                    MessageBox.Show($"Вход выполнен!");
                    MainFrame.Navigate(new ListTravelPage());
                }
                else
                {
                    MessageBox.Show($"Пользователя не существует :(");
                }
            }
        }

        private void Registration_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MainFrame.Navigate(new RegistrationPage());
        }
    }
}
