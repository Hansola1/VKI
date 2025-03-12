using data.DataBase;
using data.Model;
using System.Windows;
using System.Windows.Controls;

namespace data.Views.Pages
{
    public partial class Character : Page
    {
        private CharacterControllDB CharactertDB = new();
        public Character()
        {
            InitializeComponent();
            loadClassComboBox();
            Class_ComboBox.SelectionChanged += Class_ComboBox_SelectionChanged;
        }

        private void loadClassComboBox()
        {
            List<Characters> classCharacters = CharactertDB.GetClassComboBox();

            Class_ComboBox.ItemsSource = classCharacters;
            Class_ComboBox.DisplayMemberPath = "Class"; 
        }

        private void Class_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LoadCharacters(); // Загружаем персов ТОЛЬКО при изменении выбора
        }

        private void LoadCharacters()
        {
            var selectedClass = Class_ComboBox.SelectedItem as Characters; 

            if (selectedClass != null)
            {
                string? classCharacter = selectedClass.Class;
                List<Characters> characters = CharactertDB.GetInfoCharacter(classCharacter);
                Character_ListView.ItemsSource = characters;
            }
        }

        private void cancel_Click(object sender, RoutedEventArgs e) 
        {
            MainFrame.Navigate(new Profile());
        }
    }
}
