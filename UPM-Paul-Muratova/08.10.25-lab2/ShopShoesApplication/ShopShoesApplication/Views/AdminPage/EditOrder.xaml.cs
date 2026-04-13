using Microsoft.EntityFrameworkCore;
using ShopShoesApplication.DataControl;
using ShopShoesApplication.Models;
using System.Windows;
using System.Windows.Controls;


namespace ShopShoesApplication.Views.AdminPage
{
    public partial class EditOrder : Page
    {
        public int? orderId;
        public EditOrder(int id)
        {
            InitializeComponent();
            orderId = id;
            LoadComboBoxes();
            LoadOrder(id);
        }

        private void LoadOrder(int id)
        {
            using (var db = new ApplicationContext())
            {
                var order = db.Order.Include(p => p.Point).FirstOrDefault(p => p.Id == id);
                if (order == null) return;

                ArticleTextBox.Text = order.Article;
                AddresTextBox.Text = order.Point.Address;
                CreatedDateTextBox.Text = Convert.ToString(order.CreatedDate);
                DeliveredDateTextBox.Text = Convert.ToString(order.DeliveredDate);

                StatusSelector.SelectedValue = order.OrderStatusId;

            }
        }

        private void LoadComboBoxes()
        {
            using (var db = new ApplicationContext())
            {
                var status = db.OrderStatus.ToList();
                StatusSelector.ItemsSource = status;
                StatusSelector.DisplayMemberPath = "Name";
                StatusSelector.SelectedValuePath = "Id";
            }
        }

        private void Save_click(object sender, RoutedEventArgs e)
        {
            string article = ArticleTextBox.Text;
            string addres = AddresTextBox.Text;
            string createDate = CreatedDateTextBox.Text;
            string deliverDate = DeliveredDateTextBox.Text;

            if (string.IsNullOrEmpty(deliverDate) || string.IsNullOrEmpty(createDate) || string.IsNullOrEmpty(addres) || string.IsNullOrEmpty(article) || StatusSelector.SelectedItem == null)
            {
                MessageBox.Show("Ошибка сохранения: Ошибка в данных.");
            }

            try
            {
                using (var db = new ApplicationContext())
                {
                    var statusId = (int)StatusSelector.SelectedValue;

                    var orderToUpdate = db.Order.FirstOrDefault(p => p.Id == orderId);
                    if (orderToUpdate == null)
                    {
                        MessageBox.Show("Заказ не найден.");
                        return;
                    }

                    orderToUpdate.Article = article;
                    orderToUpdate.Point.Address = addres;
                    orderToUpdate.CreatedDate = Convert.ToDateTime(createDate);
                    orderToUpdate.DeliveredDate = Convert.ToDateTime(deliverDate);

                    db.Order.Update(orderToUpdate);
                    db.SaveChanges();

                    MessageBox.Show("Заказ успешно изменен!");
                    MainFrame.Navigate(new OrdersPage());
                }
            }
            catch
            {
                MessageBox.Show("Данные неверные!!!");
            }
        }

        private void Cancel_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new OrdersPage());
        }
    }
}