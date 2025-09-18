using OurDecorApplication.DataControl;
using OurDecorApplication.Models;
using OurDecorApplication.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace OurDecorApplication.Views
{
    public partial class ProductsPage : Page
    {
        public ProductsPage()
        {
            InitializeComponent();
            LoadDataGrid();
        }

        List<Product> product = new();
        public void LoadDataGrid()
        {
            using (var db = new ApplicationContext())
            {
                var products = db.Product.Select(s => new ProductView
                {
                    TypeProduct = s.TypeProduct.ToString(),
                    NameProduct = s.NameProduct,
                    Article = s.Article,
                    MinCostPartner = s.MinCostPartner,
                    RollWidth = s.RollWidth
                }).ToList();

                ProductsDataGrid.ItemsSource = products;
            }
        }

        private void Add_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AddProductPage());
        }

        private void Edit_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new EditProductPage());
        }

        private void ToMaterials_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MaterialsPage());
        }

        private void Cancel_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MainPage());
        }
    }
}
