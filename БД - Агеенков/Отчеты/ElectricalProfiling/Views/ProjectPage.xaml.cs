using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace ElectricalProfiling.Views
{
    public partial class ProjectPage : Page
    {
        public ProjectPage()
        {
            InitializeComponent();
        }

        private void Out_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
