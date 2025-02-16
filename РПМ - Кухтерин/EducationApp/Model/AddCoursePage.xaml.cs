using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace EducationApp.Model
{
    public partial class AddCoursePage : Page
    {
        public AddCoursePage()
        {
            InitializeComponent();
        }

        public void cancel_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MainMenuPage());
        }

        public void add_course_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Курс добавле!");
        }
    }
}
