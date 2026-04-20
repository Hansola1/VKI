using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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

namespace CreatUserControl_2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGetState_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(string.Format("State id = {0}, name = {1}", usState1.SelectedState.ID, usState1.SelectedState.Name), "Message", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
