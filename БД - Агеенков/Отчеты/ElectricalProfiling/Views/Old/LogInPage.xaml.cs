using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ElectricalProfiling.Views.Old
{
    public partial class LogInPage : Page
    {
        public LogInPage()
        {
            InitializeComponent();
        }

        private void LogIn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProjectPage());
        }
    }
}
