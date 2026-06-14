using ElectronicShopApplication.DataControl;
using ElectronicShopApplication.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace ElectronicShopApplication.Views
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

        #region ОТОБРАЖЕНИЕ
        private void LoadName()
        {
            NameAccount.Content = Session.User.Name;
        }

        private ICollectionView productsView;
        private List<ProductView> products = new();
        private void LoadListView()
        {
            using (ElectronicShopContext db = new())
            {
                 products = db.Products.Include(p => p.Provider).Include(m => m.Manufacturer).Include(c => c.Category)
                .Select(p => new ProductView 
                {
                    //Name = p.Name, Name при импорте дура потеряла)
                    Id = p.Id,
                    Cost = (int)p.Cost,

                    Provider = p.Provider.NameProvider ?? "-",
                    Manufacturer = p.Manufacturer.ManufactureName ?? "-",
                    Category = p.Category.CategoryName ?? "-",

                    Sale = (int)p.Sale,
                    Count = (int)p.Count,
                    Description = p.Description,
                    Image = p.Image,
                }).ToList();
            }

            productsView = CollectionViewSource.GetDefaultView(products);
            ProductListView.ItemsSource = productsView;
        }

        private void LoadComboBox()
        {
            using (ElectronicShopContext db = new())
            {
                var providerNames = db.Providers
                    .Select(p => p.NameProvider)
                    .Where(name => !string.IsNullOrEmpty(name)).OrderBy(name => name).ToList();

                providerNames.Insert(0, "Все поставщики");

                ProviderFilterComboBox.ItemsSource = providerNames;
                ProviderFilterComboBox.SelectedIndex = 0;
            }
        }

        private void LoadComponent()
        {
            if (Session.User?.RoleId == 2) //Пользователь
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
            this.NavigationService.Navigate(new AddEditProductPage("Добавить", null));
        }

        private void ProductListView_MouseDoubleClick(object sender, MouseButtonEventArgs e) //EDIT
        {
            if (Session.User?.RoleId == 1) //Только админ
            {
                var selected = ProductListView.SelectedItem as ProductView;
                if (selected != null)
                {
                    this.NavigationService.Navigate(new AddEditProductPage("Изменить", selected.Id));
                }
            }
        }

        private void DeleteProduct_click(object sender, RoutedEventArgs e)
        {
            var selectedProduct = ProductListView.SelectedItem as ProductView;
            if (selectedProduct != null)
            {
                using (ElectronicShopContext db = new())
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
            if (products == null || products.Count == 0 || productsView == null)
                return;

            string searchText = (SearchTextBox.Text ?? "").ToLower().Trim();
            string selectedProvider = ProviderFilterComboBox.SelectedItem as string ?? "Все поставщики";

            productsView.Filter = (item) =>
            {
                if (item is not ProductView product)
                    return false;

                if (selectedProvider != "Все поставщики" && product.Provider != selectedProvider)
                    return false;

                if (string.IsNullOrEmpty(searchText))
                    return true;

                return
                    (product.Provider?.ToLower().Contains(searchText) == true) ||
                    (product.Manufacturer?.ToLower().Contains(searchText) == true) ||
                    (product.Category?.ToLower().Contains(searchText) == true) ||
                    (product.Description?.ToLower().Contains(searchText) == true);
            };
        }

        private void SortByCount_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as Button)?.Tag is not string tag) return;

            var dir = tag == "Asc" ? ListSortDirection.Ascending : ListSortDirection.Descending;

            productsView.SortDescriptions.Clear();
            productsView.SortDescriptions.Add(new SortDescription("Count", dir));
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
