using FishShopApplication.DataControl;
using FishShopApplication.Models;
using Microsoft.EntityFrameworkCore;
using System.Windows;
using System.Windows.Controls;

namespace FishShopApplication.View
{
    public partial class AddEditPage : Page
    {
        public int? productId;
        public AddEditPage(string namePage, int? id)
        {
            InitializeComponent();
            loadNamePage(namePage);
            LoadComboBox();

            if(id != null)
            {
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
            using (var db = new ShopFishContext())
            {
                var product = db.Products.Include(p => p.Provider).FirstOrDefault(p => p.Id == id);
                if (product == null) return;

                NameTextBox.Text = product.Name;
                DescriptiontTextBox.Text = product.Description;
                PriceTextBox.Text = product.Cost.ToString();
                CountTextBox.Text = product.QuantityStock.ToString();
                DiscountTextBox.Text = product.Sale.ToString();
                MeasurementUnitTextBox.Text = product.Measurement;
                PhotoTextBox.Text = product.Image;
                ProviderTextBox.Text = product.Provider?.Name ?? "";

                CategoryProduct.SelectedValue = product.CategoryId;
                Manufacture.SelectedValue = product.ManufacturerId;
            }
        }

        private void LoadComboBox()
        {
            using (var db = new ShopFishContext())
            {
                var categories = db.ProductCategories.ToList();
                CategoryProduct.ItemsSource = categories;
                CategoryProduct.DisplayMemberPath = "Name";
                CategoryProduct.SelectedValuePath = "Id";

                var manufacturers = db.Manufacturers.ToList();
                Manufacture.ItemsSource = manufacturers;
                Manufacture.DisplayMemberPath = "Name";
                Manufacture.SelectedValuePath = "Id";
            }
        }

        private void Save_click(object sender, RoutedEventArgs e)
        {
            string photoPath = PhotoTextBox.Text;
            string name = NameTextBox.Text;
            string description = DescriptiontTextBox.Text;
            string cost = PriceTextBox.Text;
            string measurementUnit = MeasurementUnitTextBox.Text;
            string providerName = ProviderTextBox.Text;
            string countText = CountTextBox.Text;
            string discount = DiscountTextBox.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(cost) || string.IsNullOrEmpty(countText) || string.IsNullOrEmpty(description) ||
          string.IsNullOrEmpty(measurementUnit) || CategoryProduct.SelectedItem == null || Manufacture.SelectedItem == null || string.IsNullOrEmpty(discount))
            {
                MessageBox.Show("Ошибка сохранения: Ошибка в данных.");
            }


            if (productId != null)
            {
                AddProduct(photoPath, name, description, cost, measurementUnit, providerName, countText, discount);
            }
            else
            {
                EditProduct(photoPath, name, description, cost, measurementUnit, providerName, countText, discount);
            }
        }

        private void AddProduct(string photoPath, string name, string description, string cost, string measurementUnit, string providerName, string countText, string discount)
        {
            try
            {
                using (var db = new ShopFishContext())
                {
                    var categoryId = (int)CategoryProduct.SelectedValue;
                    var manufacturerId = (int)Manufacture.SelectedValue;

                    var provider = db.Providers.FirstOrDefault(r => r.Name == providerName);
                    if (provider == null)
                    {
                        MessageBox.Show("НЕТ ТАКОГО ПОСТАВЩИКА!!!");
                        return;
                    }

                    var productToAdd = new Product
                    {
                        Name = name,
                        Artucle = $"ART-{DateTime.Now:yyyyMMddHHmmss}", //нужно было как ID использовать, заглушка
                        Measurement = measurementUnit,
                        Cost = Convert.ToInt32(cost),
                        QuantityStock = Convert.ToInt32(countText),
                        Sale = Convert.ToInt32(discount),
                        Description = description,
                        Image = string.IsNullOrEmpty(photoPath) ? "Не установлено" : photoPath,
                        CategoryId = categoryId,
                        ManufacturerId = manufacturerId,
                        ProviderId = provider.Id
                    };
                    db.Products.Add(productToAdd);
                    db.SaveChanges();

                    MessageBox.Show("Товар успешно добавлен!");
                    MainFrame.Navigate(new ProductsPage());
                }
            }
            catch
            {
                MessageBox.Show("Данные неверные!!!");
            }
        }

        private void EditProduct(string photoPath, string name, string description, string cost, string measurementUnit, string providerName, string countText, string discount)
        {
            try
            {
                using (var db = new ShopFishContext())
                {
                    var productToUpdate = db.Products.FirstOrDefault(p => p.Id == productId);
                    if (productToUpdate == null)
                    {
                        MessageBox.Show("Товар не найден.");
                        return;
                    }

                    var provider = db.Providers.FirstOrDefault(p => p.Name == providerName);
                    if (provider == null)
                    {
                        MessageBox.Show("Поставщик НЕ НАЙДЕН");
                        return;
                    }

                    productToUpdate.Name = name;
                    productToUpdate.Description = description;
                    productToUpdate.Cost = Convert.ToInt32(cost);
                    productToUpdate.QuantityStock = Convert.ToInt32(countText);
                    productToUpdate.Sale = Convert.ToInt32(discount);
                    productToUpdate.Measurement = measurementUnit;
                    productToUpdate.Image = string.IsNullOrEmpty(photoPath) ? "Нет значения" : photoPath;
                    productToUpdate.CategoryId = (int)CategoryProduct.SelectedValue;
                    productToUpdate.ManufacturerId = (int)Manufacture.SelectedValue;
                    productToUpdate.ProviderId = provider.Id;

                    db.Products.Update(productToUpdate);
                    db.SaveChanges();

                    MessageBox.Show("Товар успешно изменен!");
                    MainFrame.Navigate(new ProductsPage());
                }
            }
            catch
            {
                MessageBox.Show("Данные неверные!!!");
            }
        }

        private void Cancel_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProductsPage());
        }
    }
}
