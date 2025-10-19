using Microsoft.EntityFrameworkCore;
using ShopShoesApplication.DataControl;
using ShopShoesApplication.Models;
using ShopShoesApplication.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace ShopShoesApplication.Views
{
    public partial class ProductsPage : Page
    {
        public ProductsPage()
        {
            InitializeComponent();
            LoadDataGrid();
        }

        List<ProductView> products = new();
        private void LoadDataGrid()
        {
            using (var db = new ApplicationContext())
            {
                products = db.Product
                .Include(p => p.Provider).Include(p => p.Manufacturer).Include(p => p.Category)
                .Select(p => new ProductView
                {
                    Id = p.Id,
                    Arcticle = p.Arcticle,
                    Name = p.Name,
                    MeasurementUnit = p.MeasurementUnit,
                    Price = p.Price,

                    Provider = p.Provider.Name ?? "-",
                    Manufacturer = p.Manufacturer.Name ?? "-",
                    Category = p.Category.Name ?? "-",

                    Discount = p.Discount, 
                    Count = p.Count,
                    Description = p.Description,
                    Photo = p.Photo,
                }).ToList();
            }

            ProductListView.ItemsSource = products;
        }

        private void Cancel_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new LoginPage());
        }

        private void ToOrders_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new OrdersPage());
        }
    }
}
