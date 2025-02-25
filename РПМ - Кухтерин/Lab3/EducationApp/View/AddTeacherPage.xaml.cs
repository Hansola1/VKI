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

namespace EducationApp.View
{
    public partial class AddTeacherPage : Page
    {
        public AddTeacherPage()
        {
            InitializeComponent();
        }

        private void cancel_button_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MainMenuPage());
        }

        private void edit_teacher_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Этого нет в тз))))");
        }

        private void add_teacher_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Преподаватель добавлен!");
        }
    }
}
