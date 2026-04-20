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
using System.Windows.Shapes;
using System.Data.Entity;
using Npgsql;

namespace Chat
{
    public partial class Auth : Window
    {
        AppContext DataBase = new AppContext();

        public Auth()
        {
            InitializeComponent();
        }

        private void ButtonAuthClick(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string password = passwordBox.Password.Trim();

            if (login != null && password != null)
            {

                MessageBox.Show("Приятного общения");
                ChatWin chatWindow = new ChatWin();
                chatWindow.Show();
                this.Close();

                /*  User authUser = null;
                  using (AppContext DataBase = new AppContext()) 
                  { 
                      authUser = DataBase.Users.Where(b => b.Login == login && b.Password == password).FirstOrDefault();
                  } 

                  if (authUser != null)
                  {
                      MessageBox.Show("Приятного общения");
                      ChatWin chatWindow = new ChatWin();
                      chatWindow.Show();
                      this.Close();
                  }  
                  else
                  {
                     MessageBox.Show("Данные неверны ;(");
                  } */
            }
        }

        private void ButtonRegClickWin(object sender, RoutedEventArgs e)
        {
            MainWindow mainWin = new MainWindow();
            mainWin.Show();
            this.Close();
        }
    }
}
