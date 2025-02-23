using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;
using data.DataBase;
using data.Views.Pages;

namespace data.Views.Pages
{
    public partial class Registration : Page
    {
        public Registration()
        {
            InitializeComponent();
        }

        public void login_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new LogIn());
        }

        private void reg_Click(object sender, RoutedEventArgs e)
        {
            string login = login_TextBox.Text;
            string name = name_TextBox.Text;
            string password = password_TextBox.Text;
            string email = email_TextBox.Text;
            string age = age_TextBox.Text;
            string sex = sex_TextBox.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(age) || string.IsNullOrEmpty(sex))
            {
                MessageBox.Show("Поля необходимо заполнить");
                return;
            }
            else
            {
                CreatUser();

                UserSession.IsLoggedIn = true;
                UserSession.CurrentUserLogin = login_TextBox.Text.Trim();

                MainFrame.Navigate(new Profile());
            }
        }
        private void CreatUser()
        {
            DBControll db = new DBControll();
            db.AddUser(name_TextBox.Text, login_TextBox.Text, password_TextBox.Text, email_TextBox.Text, age_TextBox.Text, sex_TextBox.Text);
        }
    }
}
