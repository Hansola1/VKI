using Microsoft.EntityFrameworkCore;
using ShopShoesApplication.DataControl;
using ShopShoesApplication.Models;
using ShopShoesApplication.ViewModels;
using ShopShoesApplication.Views.AdminPage;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace ShopShoesApplication.Views
{
    public partial class OrdersPage : Page
    {
        private List<OrderView> orders = new();
        private ICollectionView orderView;

        public OrdersPage()
        {
            InitializeComponent();
            LoadListView();
            LoadName();
        }

        #region ПОДГРУЗКА
        private void LoadListView()
        {
            using (var db = new ApplicationContext())
            {
                orders = db.Order
                .Include(p => p.Status).Include(p => p.Point) //.Include(p => p.Positions).
                .Select(p => new OrderView
                {
                    Id = p.Id,
                    Article = p.Article,
                    Status = p.Status.Name ?? "-",
                    PickupAddress = p.Point.StreetAddress ?? "-", //!!!
                    CreatedDate = p.CreatedDate,
                    DeliveredDate = p.DeliveredDate,
                }).ToList();
            }

            orderView = CollectionViewSource.GetDefaultView(orders);
            OrderListView.ItemsSource = orderView;
        }

        private void LoadName()
        {
            NameAccount.Content = Session.CurrentUser?.Name ?? "Вы гость!";
        }
        #endregion

        #region CRUD - ADD, EDIT, DELETE
        private void AddOrder_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AddOrder());
        }

        private void DeleteOrder_click(object sender, RoutedEventArgs e)
        {
            var selectedOrder = OrderListView.SelectedItem as OrderView;
            if (selectedOrder != null)
            {
                using (var db = new ApplicationContext())
                {
                    var orderToDelete = db.Order.FirstOrDefault(p => p.Id == selectedOrder.Id);

                    if (orderToDelete != null)
                    {
                        db.Order.Remove(orderToDelete);
                        db.SaveChanges();

                        LoadListView();
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите, что удалять");
            }
        }

        private void OrderListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //if (Session.CurrentUser?.RoleId == 1) //Только админ
            //{
                var selected = OrderListView.SelectedItem as OrderView;
                if (selected != null)
                {
                    MainFrame.Navigate(new EditOrder(selected.Id));
                }
            //}
        }
        #endregion

        private void Cancel_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProductsPage());
        }
    }
}
