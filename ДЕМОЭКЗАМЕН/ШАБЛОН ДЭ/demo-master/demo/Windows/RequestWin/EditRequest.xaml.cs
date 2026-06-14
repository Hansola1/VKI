using demo.Data;
using demo.Models;
using Microsoft.EntityFrameworkCore;
using System.Windows;

namespace demo.Windows.RequestWin
{
    public partial class EditRequest : Window
    {
        private DemoContext context;
        private Order order;
        public EditRequest(Order order)
        {
            InitializeComponent();
            context = new DemoContext();
            PanelOrder.DataContext = order;
            this.order = order;
            BoxStatus.ItemsSource = context.Statuses.ToList();
            BoxStatus.SelectedItem = order.Status;
            
        }

        private void Button_save(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(BoxDateDelivery.Text) &&
                !string.IsNullOrWhiteSpace(BoxDateOrder.Text) &&
                !string.IsNullOrWhiteSpace(BoxArc.Text) &&
                !string.IsNullOrWhiteSpace(BoxDelivary.Text))
            {
                try
                {

                    order.OrderDate = DateTime.Parse(BoxDateOrder.Text);
                    order.DeliveryDate = DateTime.Parse(BoxDateDelivery.Text);
                    order.Code = double.Parse(BoxArc.Text);
                    order.PickupPoint = context.PickupPoints.FirstOrDefault(q => q.Adress == BoxDelivary.Text);
                    order.Status = BoxStatus.SelectedItem as Status;
                    
                    context.Entry(order).State = EntityState.Modified;
                    context.SaveChanges();

                    DialogResult = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Button_exit(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
