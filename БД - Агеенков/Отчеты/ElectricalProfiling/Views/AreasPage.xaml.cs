using System.Windows;
using System.Windows.Controls;
using ElectricalProfiling.DataBase;
using ElectricalProfiling.Model;
using ElectricalProfiling.Views.UseControll;
using System.Windows.Media;

namespace ElectricalProfiling.Views
{
    public partial class AreasPage : Page
    {
        public AreasPage()
        {
            InitializeComponent();
        }

        private void Add_Area_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Delete_Area_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Edit_Area_Click(object sender, RoutedEventArgs e)
        {

        }

        private string _placeholderText = "Поиск площади";
        private void Find_TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Find_TextBox.Text == _placeholderText)
            {
                Find_TextBox.Text = "";
                Find_TextBox.Foreground = Brushes.Black;
            }
        }
        private void Find_TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Find_TextBox.Text))
            {
                Find_TextBox.Text = _placeholderText;
                Find_TextBox.Foreground = new SolidColorBrush(Color.FromRgb(0x15, 0x32, 0x5B)); // Восстанавливаем цвет
            }
        }

        private void FilterAreas(string searchText)
        {
            
        }

        private void Out_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Open_Project_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProjectPage());
        }
    }
}
