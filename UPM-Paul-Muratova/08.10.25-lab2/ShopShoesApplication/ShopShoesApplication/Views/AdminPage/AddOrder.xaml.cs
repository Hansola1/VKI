using ShopShoesApplication.DataControl;
using ShopShoesApplication.Models;
using System.Windows;
using System.Windows.Controls;

namespace ShopShoesApplication.Views.AdminPage
{
    public partial class AddOrder : Page
    {
        public AddOrder()
        {
            InitializeComponent();
            LoadComboBoxes();
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

            if (string.IsNullOrEmpty(deliverDate) || string.IsNullOrEmpty(createDate) ||  string.IsNullOrEmpty(addres) || string.IsNullOrEmpty(article) || StatusSelector.SelectedItem == null)
            {
                MessageBox.Show("Ошибка сохранения: Ошибка в данных.");
            }

            try
            {
                using (var db = new ApplicationContext())
                {
                    var statusId = (int)StatusSelector.SelectedValue;

                    var orderToAdd = new Order
                    {
                        Article = $"ART-{DateTime.Now:yyyyMMddHHmmss}", //нужно было как ID использовать, заглушка
                        CreatedDate = Convert.ToDateTime(createDate),
                        DeliveredDate = Convert.ToDateTime(deliverDate),
                        PointId = 1, //надо будет подумать
                        ClientId = 1, //надо будет подумать
                        Code = 1, //надо будет подумать
                        OrderStatusId = statusId,
                    };
                    db.Order.Add(orderToAdd);
                    db.SaveChanges();

                    MessageBox.Show("Заказ успешно добавлен!");
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
