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

namespace EducationApp.Model
{
    public partial class MainMenuPage : Page
    {
        public MainMenuPage()
        {
            InitializeComponent();
        }
        private void add_student_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AddStudentPage());
        }
        private void edit_student_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new EditStudentPage());
        }
        private void course_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListCoursePage());
        }
    }
}
