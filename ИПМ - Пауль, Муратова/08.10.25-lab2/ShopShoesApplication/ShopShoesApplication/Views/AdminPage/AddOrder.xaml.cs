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

namespace ShopShoesApplication.Views.AdminPage
{
    public partial class AddOrder : Page
    {
        public AddOrder()
        {
            InitializeComponent();
        }

        private void Save_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new OrdersPage());
        }

        private void Cancel_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new OrdersPage());
        }
    }
}
