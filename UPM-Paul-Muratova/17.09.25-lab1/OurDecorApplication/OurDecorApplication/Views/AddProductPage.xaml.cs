using OurDecorApplication.DataControl;
using OurDecorApplication.Models;
using System.Windows;
using System.Windows.Controls;

namespace OurDecorApplication.Views
{
    public partial class AddProductPage : Page
    {
        public AddProductPage()
        {
            InitializeComponent();
            LoadStateComboBox();
        }

        private void LoadStateComboBox()
        {
            TypeSelector.Items.Add("Декоративные обои");
            TypeSelector.Items.Add("Фотообои");
            TypeSelector.Items.Add("Обои под покраску");
            TypeSelector.Items.Add("Стеклообои");
            TypeSelector.Items.Add("Напольное покрытие");
            //чуть позже остальное...
        }

        private void Save_click(object sender, RoutedEventArgs e)
        {
            string article = ArticleTextBox.Text;
            string name = NameTextBox.Text;
            string typeProduct = TypeSelector.SelectedItem?.ToString();
            string minCostPartner = MinCostTextBox.Text;
            string rollWidth = WidthTextBox.Text;

            if (string.IsNullOrEmpty(article) || string.IsNullOrEmpty(name) || TypeSelector.SelectedItem == null
                || string.IsNullOrEmpty(minCostPartner) || string.IsNullOrEmpty(rollWidth))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            try
            {
                var newProduct = new Product
                {
                    Article = Convert.ToDouble(article),
                    TypeProduct = typeProduct,
                    NameProduct = name,
                    MinCostPartner = Convert.ToDouble(minCostPartner),
                    RollWidth = Convert.ToDouble(rollWidth)
                };

                using (var db = new ApplicationContext())
                {
                    db.Products.Add(newProduct);
                    db.SaveChanges();
                }

                MessageBox.Show("Продукт успешно добавлен!");
                MainFrame.Navigate(new ProductsPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении: {ex.Message}");
            }
        }

        private void Cancel_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProductsPage());
        }
    }
}
