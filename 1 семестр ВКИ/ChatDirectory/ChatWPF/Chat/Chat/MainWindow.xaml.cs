using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;
using Npgsql;
namespace Chat
{
    public partial class MainWindow : Window
    {
        AppContext DataBase = new AppContext();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonRegistClick(object sender, RoutedEventArgs e) 
        {
            string login = textBoxLogin.Text.Trim(); 
            string password = passwordBox.Password.Trim();     //Trim - убирает пробелы

            if (login.Length > 20 || login.Length < 3)
            {
                textBoxLogin.ToolTip = "Длина логина не более 20 знаков и не менее 3 знаков";
                textBoxLogin.Background = Brushes.Salmon;
            }
            else if (password.Length > 20 || password.Length < 4) 
            {
                passwordBox.ToolTip = "Длина пароля не более 20 знаков и не менее 4 знаков";
                passwordBox.Background = Brushes.Salmon;
            }

            else
            {
                textBoxLogin.Background = Brushes.Transparent;
                passwordBox.Background = Brushes.Transparent;

                MessageBox.Show("Ввод корректный :)");

               /* User user = new User(login, password);
                DataBase.Users.Add(user);
                DataBase.SaveChanges();  */

                Auth authWin = new Auth();
                authWin.Show();
                this.Close(); 
            }
        }

        private void ButtonAuthClickWin(object sender, RoutedEventArgs e)
        {
            Auth authWin = new Auth();
            authWin.Show();
            this.Close();
        }
    }
}
