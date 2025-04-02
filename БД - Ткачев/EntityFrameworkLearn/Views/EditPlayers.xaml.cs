using EntityFrameworkLearn.Model;
using Microsoft.EntityFrameworkCore;
using System.Windows;
using System.Windows.Controls;

namespace EntityFrameworkLearn.Views
{
    public partial class EditPlayers : Window
    {
        public EditPlayers()
        {
            InitializeComponent();
        }

        public void EditPlayer_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(login_TextBox.Text) || string.IsNullOrEmpty(password_TextBox.Text) || string.IsNullOrEmpty(name_TextBox.Text))
            {
                MessageBox.Show("Заполните поля");
                return;
            }

            string login = login_TextBox.Text;

            if (login_TextBox.Text != null)
            {
                using (var db = new ApplicationContext())
                {
                    Players playerToUpdate = db.Players.FirstOrDefault(p => p.Login == login); //var player = db.Players.FirstOrDefaultAsync(p => p.Login == login_TextBox.Text);
                    if (playerToUpdate != null)
                    {
                        playerToUpdate.Name = name_TextBox.Text;
                        playerToUpdate.Login = login_TextBox.Text;
                        playerToUpdate.Password = password_TextBox.Text;

                        db.SaveChangesAsync();
                        MessageBox.Show("Игрок изменен");
                    }
                    else
                    {
                        MessageBox.Show("Игрок не найден");
                    }
                }
            }
            else
            {
                MessageBox.Show("Логин игрока не задан");
            }
        }

        public void AddPlayer_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AddPlayers());
        }
    }
}
