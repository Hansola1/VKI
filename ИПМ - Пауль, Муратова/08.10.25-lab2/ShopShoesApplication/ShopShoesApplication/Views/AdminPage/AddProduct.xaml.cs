using ShopShoesApplication.DataControl;
using ShopShoesApplication.Models;
using System.Windows;
using System.Windows.Controls;

namespace ShopShoesApplication.Views.AdminPage
{
    public partial class AddProduct : Page
    {
        public AddProduct()
        {
            InitializeComponent();
            LoadComboBoxes(); 
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

            //ЗАДАНИЕ:
            //Стоимость товара может включать сотые части, а также не может быть отрицательной.
            //Минимальное количество также не может принимать отрицательные значения.
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
                    var categoryId = (int)CategoryProduct.SelectedValue;
                    var manufacturerId = (int)Manufacture.SelectedValue;

                    var provider = db.Provider.FirstOrDefault(r => r.Name == providerName);
                    if (provider == null)
                    {
                        MessageBox.Show("НЕТ ТАКОГО ПОСТАВЩИКА!!!");
                        return;
                    }
                    
                    var productToAdd = new Product
                    {
                        Name = name,
                        Arcticle = $"ART-{DateTime.Now:yyyyMMddHHmmss}", //нужно было как ID использовать, заглушка
                        MeasurementUnit = measurementUnit,
                        Price = price,
                        Count = count,
                        Discount = Convert.ToInt32(discount),
                        Description = description,
                        Photo = string.IsNullOrEmpty(photoPath) ? "Не установлено" : photoPath,
                        CategoryId = categoryId,
                        ManufacturerId = manufacturerId,
                        ProviderId = provider.Id
                    };
                    db.Product.Add(productToAdd);
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

        private void Cancel_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProductsPage());
        }
    }
}
