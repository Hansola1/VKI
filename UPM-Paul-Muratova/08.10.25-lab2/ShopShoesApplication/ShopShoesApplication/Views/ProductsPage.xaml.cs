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
    public partial class ProductsPage : Page
    {
        private List<ProductView> products = new();
        private ICollectionView productView;

        public ProductsPage()
        {
            InitializeComponent();
            LoadDataGrid();
            LoadComboBox();
            LoadName();
            /*LoadComponent();*/ //Для гостей, клиентов скрываю интерфейс. На время тестов закомментировала.
        }

        #region ПОДГРУЗКА
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

            productView = CollectionViewSource.GetDefaultView(products);
            ProductListView.ItemsSource = productView;
        }

        private void LoadComboBox()
        {
            using (var db = new ApplicationContext())
            {
                var providerNames = db.Provider
                    .Select(p => p.Name)
                    .Where(name => !string.IsNullOrEmpty(name)).OrderBy(name => name).ToList();

                providerNames.Insert(0, "Все поставщики"); // первый элемент

                ProviderFilterComboBox.ItemsSource = providerNames;
                ProviderFilterComboBox.SelectedIndex = 0;
            }
        }

        private void LoadName()
        {
            NameAccount.Content = Session.CurrentUser?.Name ?? "Вы гость!";
        }

        private void LoadComponent()
        {
            if (Session.Visit == true || Session.CurrentUser?.RoleId == 3) //Гость и пользователь
            {
                SearchTextBox.Visibility = Visibility.Collapsed;
                SearchLabel.Visibility = Visibility.Collapsed;
                OrderButton.Visibility = Visibility.Collapsed;
                MaxButton.Visibility = Visibility.Collapsed;
                MinButton.Visibility = Visibility.Collapsed;
                SortLabel.Visibility = Visibility.Collapsed;
                FilterLabel.Visibility = Visibility.Collapsed;
                ProviderFilterComboBox.Visibility = Visibility.Collapsed;

                AddButton.Visibility = Visibility.Collapsed;
                DeleteButton.Visibility = Visibility.Collapsed;
            }

            if (Session.CurrentUser?.RoleId == 2) //Менеджер
            {
                AddButton.Visibility = Visibility.Collapsed;
                //EditButton.Visibility = Visibility.Collapsed;
                DeleteButton.Visibility = Visibility.Collapsed;
            }
        }
        #endregion

        #region ФИЛЬТРАЦИЯ, СОРТИРОВКА

        // Общий метод обновления фильтра (поиск + поставщик)
        private void ApplyFilter()
        {
            if (products == null || products.Count == 0 || productView == null)
                return;

            string searchText = (SearchTextBox.Text ?? "").ToLower().Trim();
            string selectedProvider = ProviderFilterComboBox.SelectedItem as string ?? "Все поставщики";

            productView.Filter = (item) =>
            {
                if (item is not ProductView product)
                    return false;

                if (selectedProvider != "Все поставщики" && product.Provider != selectedProvider)
                    return false;

                if (string.IsNullOrEmpty(searchText))
                    return true;

                return
                    (product.Arcticle?.ToLower().Contains(searchText) == true) ||
                    (product.Name?.ToLower().Contains(searchText) == true) ||
                    (product.MeasurementUnit?.ToLower().Contains(searchText) == true) ||
                    (product.Provider?.ToLower().Contains(searchText) == true) ||
                    (product.Manufacturer?.ToLower().Contains(searchText) == true) ||
                    (product.Category?.ToLower().Contains(searchText) == true) ||
                    (product.Description?.ToLower().Contains(searchText) == true);
            };
        }

        private void SortByCount_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as Button)?.Tag is not string tag) return;

            var dir = tag == "Asc"
                ? ListSortDirection.Ascending
                : ListSortDirection.Descending;

            productView.SortDescriptions.Clear();
            productView.SortDescriptions.Add(new SortDescription("Count", dir));
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

        #region CRUD - ADD, EDIT, DELETE
        private void AddProduct_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AddProduct());
        }

        private void ProductListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (Session.CurrentUser?.RoleId == 1) //Только админ
            {
                var selected = ProductListView.SelectedItem as ProductView;
                if (selected != null)
                {
                    MainFrame.Navigate(new EditProduct(selected.Id));
                }
            }
        }

        private void DeleteProduct_click(object sender, RoutedEventArgs e)
        {
            var selectedProduct = ProductListView.SelectedItem as ProductView;
            if (selectedProduct != null)
            {
                using (var db = new ApplicationContext())
                {
                    var productToDelete = db.Product.FirstOrDefault(p => p.Id == selectedProduct.Id);

                    if (productToDelete != null)
                    {
                        db.Product.Remove(productToDelete);
                        db.SaveChanges();

                        LoadDataGrid();
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите, что удалять");
            }
        }
        #endregion


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
