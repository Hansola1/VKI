using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace EducationPlans.View
{
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

       
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            string textCurrent = nameTextBox.Text;

            nameTextBox.Text = "";
            nameTextBox.Foreground = Brushes.Black;
        }
        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            //nameTextBox.Text = textCurrent;
            nameTextBox.Foreground = new SolidColorBrush(Color.FromRgb(0x15, 0x32, 0x5B)); 
        }

        private void loginClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new JournalPage());
        }
    }
}
