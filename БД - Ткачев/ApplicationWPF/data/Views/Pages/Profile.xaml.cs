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
using System.Xml.Linq;
using data.DataBase;
using data.Views.Pages;

namespace data.Views.Pages
{
    public partial class Profile : Page
    {
        public Profile()
        {
            InitializeComponent();
            //подгрузка лист вью тут всунуть
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
                DBControll db = new DBControll();
                int? userID = db.GetCurrentUserID(UserSession.CurrentUserLogin);

                db.AddCharacter(userID, species, nameCharacter, level, classCharacter);
            }
        }

        private void UpdateTable_Click(object sender, RoutedEventArgs e)
        {
           // на подумать
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
                DBControll db = new DBControll();
                string name = db.GetLoginUser(ID);

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
    }
}
