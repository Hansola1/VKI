using BuildingShopApplication.DataControl;
using BuildingShopApplication.ViewModels;
using BuildingShopApplication.Views.UserControls;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace BuildingShopApplication.Views
{
    public partial class ProductsPage : Page
    {
        public ProductsPage()
        {
            InitializeComponent();
            LoadName();
            LoadListView();
            //LoadComboBox();
            //LoadComponent();
        }

        #region ОТОБРАЖЕНИЕ
        private void LoadName()
        {
            NameAccount.Content = Session.User.Name;
        }

        private ICollectionView productsView;
        private List<ProductView> products = new();
        private void LoadListView()
        {
            using (BuildingShopDbContext db = new())
            {
                products = db.Products.Include(m => m.Manufacturer).Include(c => c.Category)
               .Select(p => new ProductView
               {
                   Article = p.Article,
                   Description = p.Description,
                   Manufacturer = p.Manufacturer.Name ?? "-",
                   Cost = (int)p.Cost,
                   StockQuantity = (int)p.StockQuantity,
                   MaxDiscount = (int)p.MaxDiscount,
                   Image = p.Image,
               }).ToList();
            }

            productsView = CollectionViewSource.GetDefaultView(products);
            ProductListView.ItemsSource = productsView;
        }

        private void LoadComponent()
        {
            if (Session.User?.RoleId == 3 || Session.User?.RoleId == 2) //Клиент и менеджер
            {
                AddButton.Visibility = Visibility.Collapsed;
                DeleteButton.Visibility = Visibility.Collapsed;
            }
        }
        #endregion

        #region CRUD - ADD, EDIT, DELETE
        private void AddProduct_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AddEditProductPage("Добавить", null));
        }

        private void ProductListView_MouseDoubleClick(object sender, MouseButtonEventArgs e) //EDIT
        {
            if (Session.User?.RoleId == 1) //Только админ
            {
                var selected = ProductListView.SelectedItem as ProductView;
                if (selected != null)
                {
                    this.NavigationService.Navigate(new AddEditProductPage("Изменить", selected.Article));
                }
            }
        }

        private void DeleteProduct_click(object sender, RoutedEventArgs e)
        {
            var selectedProduct = ProductListView.SelectedItem as ProductView;
            if (selectedProduct != null)
            {
                using (BuildingShopDbContext db = new())
                {
                    var productToDelete = db.Products.FirstOrDefault(p => p.Article == selectedProduct.Article);

                    if (productToDelete != null)
                    {
                        db.Products.Remove(productToDelete);
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
        #endregion


        #region ФИЛЬТРАЦИЯ, СОРТИРОВКА, ПОИСК
        private void ApplyFilter()
        {
            if (products == null || products.Count == 0 || productsView == null)
                return;

            string searchText = (SearchTextBox.Text ?? "").ToLower().Trim();

            productsView.Filter = (item) =>
            {
                if (item is not ProductView product)
                    return false;

                if (string.IsNullOrEmpty(searchText))
                    return true;

                return
                    (product.Article?.ToLower().Contains(searchText) == true) ||
                    (product.Manufacturer?.ToLower().Contains(searchText) == true) ||
                    (product.Name?.ToLower().Contains(searchText) == true) ||
                    (product.Description?.ToLower().Contains(searchText) == true);
            };
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ApplyFilter();
        }

        private void ProviderFilterComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ApplyFilter();
        }
        #endregion
        private void Cancel_click(object sender, RoutedEventArgs e)
        {
            //MainFrame.Navigate(new LoginPage());
            this.NavigationService.Navigate(new LoginPage());
        }
    }
}
