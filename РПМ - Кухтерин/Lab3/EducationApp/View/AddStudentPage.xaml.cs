using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace EducationApp.View
{
    public partial class AddStudentPage : Page
    {
        public AddStudentPage()
        {
            InitializeComponent();
        }

        private void cancel_button_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MainMenuPage());
        }

        private void edit_student_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Этого нет в тз))))");
            //MainFrame.Navigate(new EditStudentPage());
        }

        private void add_student_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Студент добавлен!");
        }
    }
}
