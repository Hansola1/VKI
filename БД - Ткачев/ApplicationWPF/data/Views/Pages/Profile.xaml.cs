using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using data.DataBase;
using data.Model;
using data.Views.Pages;

namespace data.Views.Pages
{
    public partial class Profile : Page
    {
        private UserControllDB userDB = new();
        private CharacterControllDB characterDB = new();

        public Profile()
        {
            InitializeComponent();
            LoadCharacters();
        }

        private void LoadCharacters()
        {
            int? userID = userDB.GetCurrentUserID(UserSession.CurrentUserLogin);

            if (userID != null)
            {
                List<Character> characters = characterDB.GetUserCharacters(userID); //для текущего пользователя
                Characters_ListView.ItemsSource = characters;
            }
            else
            {
                MessageBox.Show("Ошибка при загрузке персонажей");
            }
        }

        private void addCharacter_Click(object sender, RoutedEventArgs e)
        {
            string nameCharacter = nameCharacter_TextBox.Text;
            string species = species_TextBox.Text;
            string level = level_TextBox.Text;
            string classCharacter = classCharacter_TextBox.Text;

            if (string.IsNullOrEmpty(nameCharacter) || string.IsNullOrEmpty(species) || string.IsNullOrEmpty(level) || string.IsNullOrEmpty(classCharacter))
            {
                MessageBox.Show("Поля необходимо заполнить");
                return;
            }
            else
            {
                int? userID = userDB.GetCurrentUserID(UserSession.CurrentUserLogin);
                characterDB.AddCharacter(userID, species, nameCharacter, level, classCharacter);
            }
        }

        private void UpdateTable_Click(object sender, RoutedEventArgs e)
        {
            LoadCharacters();
        }

        private void getUser_Click(object sender, RoutedEventArgs e)
        {
            string ID = ID_TextBox.Text.Trim();

            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Поле необходимо заполнить");
                return;
            }
            else
            {
                string name = userDB.GetLoginUser(ID);

                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Пользователь не найден");
                }
                else
                {
                    MessageBox.Show($"Пользователь найден: {name}");
                }
            }
        }

        private void location_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Location());
        }
    }
}
