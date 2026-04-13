using Shop.DataControl;
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

namespace Shop.Views
{
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private bool ValidationData()
        {
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Заполните поля");
                return false;
            }

            using (var db = new ApplicationContext())
            {
                var user = db.Customers.FirstOrDefault(p => p.email == email && p.pasword == password);
                if (user == null)
                {
                    MessageBox.Show("Пользователя не существует");
                    return false;
                }

                return true;
            }
        }

        private void ToOrdersClick(object sender, RoutedEventArgs e)
        {
            if (ValidationData())
            {
                MainFrame.Navigate(new OrdersPage());
            }
        }
    }
}
