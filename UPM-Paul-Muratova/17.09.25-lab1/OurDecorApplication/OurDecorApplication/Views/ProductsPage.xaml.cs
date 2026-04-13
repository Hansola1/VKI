using OurDecorApplication.DataControl;
using OurDecorApplication.Models;
using OurDecorApplication.ViewModels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

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
            var selected = ProductsListView.SelectedItem as ProductView;
            if (selected == null)
            {
                MessageBox.Show("Выберите продукт для редактирования");
                return;
            }

            MainFrame.Navigate(new EditProductPage(selected.Article, selected.TypeProduct, selected.NameProduct, selected.MinCostPartner, selected.RollWidth));
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
