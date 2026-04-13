using demo.Data;
using demo.Models;
using Microsoft.EntityFrameworkCore;
using System.Windows;

namespace demo.Windows
{
    public partial class Authorization : Window
    {
        private DemoContext context;
        public Authorization()
        {
            InitializeComponent();
            context = new DemoContext();
        }

        private void Button_authorization(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(BoxLogin.Text) && !string.IsNullOrWhiteSpace(BoxPassword.Text))
            {
                User user = context.Users.FirstOrDefault(q => q.Login == BoxLogin.Text && q.Password == BoxPassword.Text);
                user.RoleNavigation = context.Roles.FirstOrDefault(q => q.Id == user.Role);
                if (user != null)
                {
                    Main main = new Main(user);
                    main.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Пользователь не найден");
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }

        private void Button_authorization_gouest(object sender, RoutedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }
    }
}
