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
    /// <summary>
    /// Логика взаимодействия для ListCoursePage.xaml
    /// </summary>
    public partial class ListCoursePage : Page
    {
        public ListCoursePage()
        {
            InitializeComponent();
        }

        public void add_course_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AddCoursePage());
        }

        public void cancel_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MainMenuPage());
        }
    }
}
