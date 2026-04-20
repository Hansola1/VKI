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

using System.Diagnostics;

namespace MyFromToUseControlTraining
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MyUseControlForPassword_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void MyComponent1_MyTick(object sender, EventArgs e)
        {
            labelForTick.Content = DateTime.Now.ToString();
        }


        private void ShowD_Click(object sender, RoutedEventArgs e)
        {
            myForm MyForm = new myForm();
            MyForm.ShowDialog();
        }
        private void Ok_button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }
    }
}
