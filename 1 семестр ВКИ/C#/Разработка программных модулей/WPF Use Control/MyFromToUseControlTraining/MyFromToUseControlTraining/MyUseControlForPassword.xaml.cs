using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace MyFromToUseControlTraining
{

    public partial class MyUseControlForPassword : UserControl
    {
        public MyUseControlForPassword()
        {
            InitializeComponent();
        }

        public string LabelText
        {
            get { return labeld.Content.ToString(); }
            set { labeld.Content = value; }
        }
        public string Password
        {
            get { return passwordBox.Password; }
            set { passwordBox.Password = value; }
        }

        private void visPassword_Click(object sender, RoutedEventArgs e)
        {
            Password = passwordBox.Password;
            //passwordBox.PasswordChar = !passwordBox.PasswordChar;

            if (passwordBox.PasswordChar == '\0')
            {
                passwordBox.PasswordChar = '●';
            }
            else
            {
                passwordBox.PasswordChar = '\0';
            }
        }
    }
}
