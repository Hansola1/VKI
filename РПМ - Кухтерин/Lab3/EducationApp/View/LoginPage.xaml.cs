using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace EducationApp.View
{
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            MainFrame.Navigate(new MainMenuPage());
        }
    }
}
