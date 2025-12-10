using FishShopApplication.DataControl;
using FishShopApplication.Models;
using FishShopApplication.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace FishShopApplication.View
{
    public partial class ProductsPage : Page
    {
        public ProductsPage()
        {
            InitializeComponent();
            LoadName();
            LoadListView();
            LoadComboBox();
            LoadComponent();
        }

        #region ПОДГРУЗКА

        private List<ProductView> products = new List<ProductView>();
        private ICollectionView productView;
        private void LoadListView()
        {
            using (var db = new ShopFishContext())
            {
                products = db.Products
                .Include(p => p.Provider).Include(p => p.ProviderNavigation).Include(p => p.Category)
                .Select(p => new ProductView
                {
                    Id = p.Id,
                    Artucle = p.Artucle,
                    Name = p.Name,
                    Measurement = p.Measurement,
                    Cost = (int)p.Cost,

                    Provider = p.Provider.Name ?? "-",
                    Manufacturer = p.ProviderNavigation.Name ?? "-",
                    Category = p.Category.Category ?? "-",

                    Sale = (int)p.Sale,
                    QuantityStock = (int)p.QuantityStock,
                    Description = p.Description,
                    Image = p.Image,
                }).ToList();
            }

            productView = CollectionViewSource.GetDefaultView(products);
            ProductListView.ItemsSource = productView;
        }

        private void LoadComboBox()
        {
            using (var db = new ShopFishContext())
            {
                var providerNames = db.Providers
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
            if (Session.Visit == true || Session.CurrentUser?.RoleId == 1) //Пользователь
            {
                SearchTextBox.Visibility = Visibility.Collapsed;
                SearchLabel.Visibility = Visibility.Collapsed;
                MaxButton.Visibility = Visibility.Collapsed;
                MinButton.Visibility = Visibility.Collapsed;
                SortLabel.Visibility = Visibility.Collapsed;
                FilterLabel.Visibility = Visibility.Collapsed;
                ProviderFilterComboBox.Visibility = Visibility.Collapsed;

                AddButton.Visibility = Visibility.Collapsed;
                DeleteButton.Visibility = Visibility.Collapsed;
            }
        }
        #endregion

        #region CRUD - ADD, EDIT, DELETE
        private void AddProduct_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AddEditPage("Добавить", null));
        }

        private void ProductListView_MouseDoubleClick(object sender, MouseButtonEventArgs e) //EDIT
        {
            if (Session.CurrentUser?.RoleId == 2) //Только админ
            {
                var selected = ProductListView.SelectedItem as ProductView;
                if (selected != null)
                {
                    MainFrame.Navigate(new AddEditPage("Изменить", selected.Id));
                }
            }
        }

        private void DeleteProduct_click(object sender, RoutedEventArgs e)
        {
            var selectedProduct = ProductListView.SelectedItem as ProductView;
            if (selectedProduct != null)
            {
                using (var db = new ShopFishContext())
                {
                    var productToDelete = db.Products.FirstOrDefault(p => p.Id == selectedProduct.Id);

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
                    (product.Artucle?.ToLower().Contains(searchText) == true) ||
                    (product.Name?.ToLower().Contains(searchText) == true) ||
                    (product.Measurement?.ToLower().Contains(searchText) == true) ||
                    (product.Provider?.ToLower().Contains(searchText) == true) ||
                    (product.Manufacturer?.ToLower().Contains(searchText) == true) ||
                    (product.Category?.ToLower().Contains(searchText) == true) ||
                    (product.Description?.ToLower().Contains(searchText) == true);
            };
        }

        private void SortByCount_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as Button)?.Tag is not string tag) return;

            var dir = tag == "Asc" ? ListSortDirection.Ascending: ListSortDirection.Descending;

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


        private void Cancel_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new LoginPage());
        }
    }
}
