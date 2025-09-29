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
            LoadListView();
        }

        List<ProductView> products = new();
        public void LoadListView()
        {
            using (var db = new ApplicationContext())
            {
                products = db.Products.Select(s => new ProductView
                {                 
                    TypeProduct = s.TypeProduct,
                    NameProduct = s.NameProduct,
                    Article = s.Article,
                    MinCostPartner = s.MinCostPartner,
                    RollWidth = s.RollWidth
                }).ToList();

                ProductsListView.ItemsSource = products;
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
