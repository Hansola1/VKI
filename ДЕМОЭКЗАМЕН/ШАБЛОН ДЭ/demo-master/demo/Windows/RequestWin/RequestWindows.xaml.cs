using demo.Data;
using demo.Models;
using demo.UserControllers;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace demo.Windows.RequestWin
{
    public partial class RequestWindows : Window
    {
        private DemoContext Context;
        public RequestWindows(User user)
        {
            InitializeComponent();
            Context = new DemoContext();

            List<Order> orders = Context.Orders
                .Include(q => q.PickupPoint)
                .Include(q => q.Status)
                .ToList();
            BoxOrder.ItemsSource = Context.Orders.ToList();

            if (user.RoleNavigation.Role1 == "Администратор")
            {
                BoxOrder.MouseDoubleClick += BoxProduct_MouseDoubleClick; ;
                PanelBottomButton.Visibility = Visibility.Visible;
            }
            else
            {
                PanelBottomButton.Visibility= Visibility.Collapsed;
            }
        }

        private void BoxProduct_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Order order = BoxOrder.SelectedItem as Order;
            if (order != null)
            {
                EditRequest edit = new EditRequest(order);

                if (edit.ShowDialog() == true)
                {
                    BoxOrder.ItemsSource = Context.Orders.ToList();
                }
            }
        }

        private void Button_add_reques(object sender, RoutedEventArgs e)
        {
            AddRequest add = new AddRequest();
            if(add.ShowDialog() == true)
            {
                BoxOrder.ItemsSource = Context.Orders.ToList();
            }
        }

        private void Buutton_delite_reques(object sender, RoutedEventArgs e)
        {
            Order prod = BoxOrder.SelectedItem as Order;
            if (prod != null)
            {
                var order = Context.OrderArticles.FirstOrDefault(q => q.ProductId == prod.Id) ?? null;

                var ordersArticles = Context.OrderArticles.Where(q=> q.Order == prod);
                if (ordersArticles != null)
                {
                    Context.OrderArticles.RemoveRange(ordersArticles);
                }
                Context.Orders.Remove(prod);
                Context.SaveChanges();
                BoxOrder.ItemsSource = Context.Orders.ToList();
            }
            else
            {
                MessageBox.Show("Выберете заказ для удаления");
            }
        }

        private void Button_exit(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
