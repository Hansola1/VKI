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

namespace CreatUserControl
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UpdateNameLabel()
        {
            if (string.IsNullOrWhiteSpace(ctlFirstName.Text) || string.IsNullOrWhiteSpace(ctlLastName.Text))
                lblFullName.Text = "Please fill out both the first name and the last name.";
            else
                lblFullName.Text = $"Hello {ctlFirstName.Text} {ctlLastName.Text}, I hope you're having a good day.";
        }

        private void ctlFirstName_TextChanged(object sender, EventArgs e)
        {
            UpdateNameLabel();
        }

        private void ctlLastName_TextChanged(object sender, EventArgs e)
        {
            UpdateNameLabel();
        }

        private void Form1_Load(object sender, EventArgs e) => UpdateNameLabel();
    }
}
