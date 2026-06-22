using ElectronicShopApplication.DataControl;
using ElectronicShopApplication.Models;
using Microsoft.EntityFrameworkCore;
using System.Windows;
using System.Windows.Controls;

namespace ElectronicShopApplication.Views
{
    public partial class AddEditProductPage : Page
    {
        public int? productId;
        public AddEditProductPage(string namePage, int? id)
        {
            InitializeComponent();
            loadNamePage(namePage);
            LoadComboBox();

            if (id != null)
            {
                productId = id;
                LoadProduct(id);
            }
        }

        private void loadNamePage(string namePage)
        {
            if (namePage == "Добавить") LabelPage.Text = "Добавить продукт";
            if (namePage == "Изменить") LabelPage.Text = "Изменить продукт";
        }

        private void LoadProduct(int? id)
        {
            using (ElectronicShopContext db = new())
            {
                var product = db.Products.Include(p => p.Provider).FirstOrDefault(p => p.Id == id);
                if (product == null) return;

                //NameTextBox.Text = product.Name; дура потеряла при импорте)
                DescriptiontTextBox.Text = product.Description;
                PriceTextBox.Text = product.Cost.ToString();
                CountTextBox.Text = product.Count.ToString();
                DiscountTextBox.Text = product.Sale.ToString();
                //MeasurementUnitTextBox.Text = product.Measurement; вообще в тз нет, а в данных импорта есть
                PhotoTextBox.Text = product.Image;

                ProviderComboBox.SelectedValue = product.ProviderId;
                CategoryProductComboBox.SelectedValue = product.CategoryId;
                ManufactureComboBox.SelectedValue = product.ManufacturerId;
            }
        }

        private void LoadComboBox()
        {
            using (ElectronicShopContext db = new())
            {
                var categories = db.CategoryProducts.ToList();
                CategoryProductComboBox.ItemsSource = categories;
                CategoryProductComboBox.DisplayMemberPath = "CategoryName";
                CategoryProductComboBox.SelectedValuePath = "Id";

                var manufacturers = db.Manufacturers.ToList();
                ManufactureComboBox.ItemsSource = manufacturers;
                ManufactureComboBox.DisplayMemberPath = "ManufactureName";
                ManufactureComboBox.SelectedValuePath = "Id";

                var provider = db.Providers.ToList();
                ProviderComboBox.ItemsSource = provider;
                ProviderComboBox.DisplayMemberPath = "NameProvider";
                ProviderComboBox.SelectedValuePath = "Id";
            }
        }

        private void Save_click(object sender, RoutedEventArgs e)
        {
            string photoPath = PhotoTextBox.Text;
            string name = NameTextBox.Text;
            string description = DescriptiontTextBox.Text;
            string cost = PriceTextBox.Text;
            string providerName = ProviderComboBox.Text;
            string countText = CountTextBox.Text;
            string discount = DiscountTextBox.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(cost) || string.IsNullOrEmpty(countText) || string.IsNullOrEmpty(description) 
                || CategoryProductComboBox.SelectedItem == null || ManufactureComboBox.SelectedItem == null || string.IsNullOrEmpty(discount))
            {
                MessageBox.Show("Ошибка сохранения: Ошибка в данных.");
            }


            if (productId != null)
            {
                EditProduct(photoPath, name, description, cost, countText, discount);
            }
            else
            {
                AddProduct(photoPath, name, description, cost, countText, discount);
            }
        }

        private void AddProduct(string photoPath, string name, string description, string cost, string countText, string discount)
        {
            try
            {
                using (ElectronicShopContext db = new())
                {
                    var productToAdd = new Product
                    {
                        //Name = name,
                        Artucle = $"ART-{DateTime.Now:yyyyMMddHHmmss}", //нужно было как ID использовать, заглушка
                        Cost = Convert.ToInt32(cost),
                        Count = Convert.ToInt32(countText),
                        Sale = Convert.ToInt32(discount),
                        Description = description,
                        Image = photoPath,
                        CategoryId = (int)CategoryProductComboBox.SelectedValue,
                        ManufacturerId = (int)ManufactureComboBox.SelectedValue,
                        ProviderId = (int)ProviderComboBox.SelectedValue,
                    };
                    db.Products.Add(productToAdd);
                    db.SaveChanges();

                    MessageBox.Show("Товар успешно добавлен!");
                    this.NavigationService.Navigate(new ProductsPage());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ОШИБКА: Перепроверьте данные. См.подробности: {ex.Message}");
            }
        }

        private void EditProduct(string photoPath, string name, string description, string cost, string countText, string discount)
        {
            try
            {
                using (ElectronicShopContext db = new())
                {
                    var productToUpdate = db.Products.FirstOrDefault(p => p.Id == productId);
                    if (productToUpdate == null)
                    {
                        MessageBox.Show("Товар не найден.");
                        return;
                    }

                    //productToUpdate.Name = name;
                    productToUpdate.Description = description;
                    productToUpdate.Cost = Convert.ToInt32(cost);
                    productToUpdate.Count = Convert.ToInt32(countText);
                    productToUpdate.Sale = Convert.ToInt32(discount);
                    productToUpdate.Image = string.IsNullOrEmpty(photoPath) ? "Нет значения" : photoPath;
                    productToUpdate.CategoryId = (int)CategoryProductComboBox.SelectedValue;
                    productToUpdate.ManufacturerId = (int)ManufactureComboBox.SelectedValue;
                    productToUpdate.ProviderId = (int)ProviderComboBox.SelectedValue;

                    db.Products.Update(productToUpdate);
                    db.SaveChanges();

                    MessageBox.Show("Товар успешно изменен!");
                    this.NavigationService.Navigate(new ProductsPage());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ОШИБКА: Перепроверьте данные. См.подробности: {ex.Message}");
            }
        }

        private void Cancel_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ProductsPage());
        }
    }
}
