using CarsharingApp.DataBase;
using System.Windows;
using System.Windows.Controls;

namespace CarsharingApp.Views
{

    public partial class RegistrationPage : Page
    {
        private DB_UsersController dbUsers = new();
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MainFrame.Navigate(new LoginPage());
        }

        private void Registration_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            string login = Login_TextBox.Text;
            string lastname = LastName_TextBox.Text;
            string firstname = FirstName_TextBox.Text;
            string surname = Surname_TextBox.Text;
            string password = Password_TextBox.Text;
            string email = Email_TextBox.Text;
            string phone = Phone_TextBox.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Поля необходимо заполнить");
                return;
            }
            else
            {
                UserSession.IsLoggedIn = true;
                UserSession.CurrentUserLogin = Login_TextBox.Text.Trim();

                CreateUser(); 
                MainFrame.Navigate(new LoginPage());
            }
        }
        private void CreateUser()
        {
            dbUsers.AddUser(Login_TextBox.Text, Password_TextBox.Text, LastName_TextBox.Text, FirstName_TextBox.Text, Surname_TextBox.Text, Phone_TextBox.Text, Email_TextBox.Text);
        }
    }
}
