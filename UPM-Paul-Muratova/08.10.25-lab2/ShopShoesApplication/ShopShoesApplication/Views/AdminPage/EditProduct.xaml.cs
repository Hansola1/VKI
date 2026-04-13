using Microsoft.EntityFrameworkCore;
using ShopShoesApplication.DataControl;
using ShopShoesApplication.Models;
using System.Windows;
using System.Windows.Controls;

namespace ShopShoesApplication.Views.AdminPage
{
    public partial class EditProduct : Page
    {
        public int? productId;

        public EditProduct(int Id)
        {
            InitializeComponent();

            productId = Id;
            LoadComboBoxes();
            LoadProduct(Id);
        }

        private void LoadProduct(int id)
        {
            using (var db = new ApplicationContext())
            {
                var product = db.Product.Include(p => p.Provider).FirstOrDefault(p => p.Id == id);
                if (product == null) return;

                NameTextBox.Text = product.Name;
                DescriptiontTextBox.Text = product.Description;
                PriceTextBox.Text = product.Price.ToString();
                CountTextBox.Text = product.Count.ToString();
                DiscountTextBox.Text = product.Discount.ToString();
                MeasurementUnitTextBox.Text = product.MeasurementUnit;
                PhotoTextBox.Text = product.Photo;
                ProviderTextBox.Text = product.Provider?.Name ?? "";

                CategoryProduct.SelectedValue = product.CategoryId;
                Manufacture.SelectedValue = product.ManufacturerId;
            }
        }

        private void LoadComboBoxes()
        {
            using (var db = new ApplicationContext())
            {
                var categories = db.Category.ToList();
                CategoryProduct.ItemsSource = categories;
                CategoryProduct.DisplayMemberPath = "Name";
                CategoryProduct.SelectedValuePath = "Id";

                var manufacturers = db.Manufacturer.ToList();
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
            string priceText = PriceTextBox.Text;
            string measurementUnit = MeasurementUnitTextBox.Text;
            string providerName = ProviderTextBox.Text;
            string countText = CountTextBox.Text;
            string discount = DiscountTextBox.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(priceText) || string.IsNullOrEmpty(countText) || string.IsNullOrEmpty(description) ||
            string.IsNullOrEmpty(measurementUnit) || CategoryProduct.SelectedItem == null || Manufacture.SelectedItem == null || string.IsNullOrEmpty(discount))
            {
                MessageBox.Show("Ошибка сохранения: Ошибка в данных.");
            }

            bool priceValid = int.TryParse(priceText, out int price) && price > 0;
            bool countValid = int.TryParse(countText, out int count) && count > 0;

            if (!priceValid || !countValid)
            {
                MessageBox.Show("Стоимость товара и количество не могут быть отрицательными.");
                return;
            }

            try
            {
                using (var db = new ApplicationContext())
                {
                    var productToUpdate = db.Product.FirstOrDefault(p => p.Id == productId);
                    if (productToUpdate == null)
                    {
                        MessageBox.Show("Товар не найден.");
                        return;
                    }

                    var provider = db.Provider.FirstOrDefault(p => p.Name == providerName);
                    if (provider == null)
                    {
                        MessageBox.Show("Поставщик НЕ НАЙДЕН");
                        return;
                    }

                    productToUpdate.Name = name;
                    productToUpdate.Description = description;
                    productToUpdate.Price = price;
                    productToUpdate.Count = count;
                    productToUpdate.Discount = Convert.ToInt32(discount);
                    productToUpdate.MeasurementUnit = measurementUnit;
                    productToUpdate.Photo = string.IsNullOrEmpty(photoPath) ? "Нет значения" : photoPath;
                    productToUpdate.CategoryId = (int)CategoryProduct.SelectedValue;
                    productToUpdate.ManufacturerId = (int)Manufacture.SelectedValue;
                    productToUpdate.ProviderId = provider.Id;

                    db.Product.Update(productToUpdate);
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
