using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace EducationApp.View
{
    public partial class ListCoursePage : Page
    {
        public ListCoursePage()
        {
            InitializeComponent();
        }

        private void add_course_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AddCoursePage());
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MainMenuPage());
        }

        private void delete_course_Click(Object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Этого нет в тз))");
        }
    }
}
