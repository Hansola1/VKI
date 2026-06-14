using BuildingShopApplication.DataControl;
using System.Windows;
using System.Windows.Controls;

namespace BuildingShopApplication.Views.UserControls
{
    public partial class AddEditProductPage : Page
    {
        public string? productId;
        public AddEditProductPage(string namePage, string? id)
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

        private void LoadProduct(string? id)
        {
            using (BuildingShopDbContext db = new())
            {
                var product = db.Products.FirstOrDefault(p => p.Article == id); //.Include(p => p.).FirstOrDefault(p => p.Id == id);
                if (product == null) return;

                NameTextBox.Text = product.Name;
                DescriptiontTextBox.Text = product.Description;
                PriceTextBox.Text = product.Cost.ToString();
                CountTextBox.Text = product.StockQuantity.ToString();
                DiscountTextBox.Text = product.Cost.ToString();
                //MeasurementUnitTextBox.Text = product.;
                //PhotoTextBox.Text = product.Image;

                ProviderComboBox.SelectedValue = product.SupplierId;
                CategoryProductComboBox.SelectedValue = product.CategoryId;
                ManufactureComboBox.SelectedValue = product.ManufacturerId;
            }
        }

        private void LoadComboBox()
        {
            using (BuildingShopDbContext db = new())
            {
                var categories = db.Categories.ToList();
                CategoryProductComboBox.ItemsSource = categories;
                CategoryProductComboBox.DisplayMemberPath = "Name";
                CategoryProductComboBox.SelectedValuePath = "Id";

                var manufacturers = db.Manufacturers.ToList();
                ManufactureComboBox.ItemsSource = manufacturers;
                ManufactureComboBox.DisplayMemberPath = "Name";
                ManufactureComboBox.SelectedValuePath = "Id";

                var provider = db.Suppliers.ToList();
                ProviderComboBox.ItemsSource = provider;
                ProviderComboBox.DisplayMemberPath = "Name";
                ProviderComboBox.SelectedValuePath = "Id";
            }
        }

        private void Save_click(object sender, RoutedEventArgs e)
        {
            //string photoPath = PhotoTextBox.Text;
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
                EditProduct(name, description, cost, countText, discount);
            }
            else
            {
                AddProduct(name, description, cost, countText, discount);
            }
        }

        private void AddProduct(string name, string description, string cost, string countText, string discount)
        {
            try
            {
                using (BuildingShopDbContext db = new())
                {
                    var productToAdd = new Product
                    {
                        Name = name,
                        Article = $"ART-{DateTime.Now:yyyyMMddHHmmss}", //нужно было как ID использовать, заглушка
                        Cost = Convert.ToInt32(cost),
                        StockQuantity = Convert.ToInt32(countText),
                        CurrentDiscount = Convert.ToInt32(discount),
                        Description = description,
                        //Image = photoPath,
                        CategoryId = (int)CategoryProductComboBox.SelectedValue,
                        ManufacturerId = (int)ManufactureComboBox.SelectedValue,
                        SupplierId = (int)ProviderComboBox.SelectedValue,
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

        private void EditProduct(string name, string description, string cost, string countText, string discount)
        {
            try
            {
                using (BuildingShopDbContext db = new())
                {
                    var productToUpdate = db.Products.FirstOrDefault(p => p.Article == productId);
                    if (productToUpdate == null)
                    {
                        MessageBox.Show("Товар не найден.");
                        return;
                    }

                    productToUpdate.Name = name;
                    productToUpdate.Description = description;
                    productToUpdate.Cost = Convert.ToInt32(cost);
                    productToUpdate.StockQuantity = Convert.ToInt32(countText);
                    productToUpdate.CurrentDiscount = Convert.ToInt32(discount);
                    //productToUpdate.Image = string.IsNullOrEmpty(photoPath) ? "Нет значения" : photoPath;
                    productToUpdate.CategoryId = (int)CategoryProductComboBox.SelectedValue;
                    productToUpdate.ManufacturerId = (int)ManufactureComboBox.SelectedValue;
                    productToUpdate.SupplierId = (int)ProviderComboBox.SelectedValue;

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
