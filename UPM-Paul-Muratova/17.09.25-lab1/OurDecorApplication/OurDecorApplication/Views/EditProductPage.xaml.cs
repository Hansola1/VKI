using OurDecorApplication.DataControl;
using System.Windows;
using System.Windows.Controls;

namespace OurDecorApplication.Views
{
    public partial class EditProductPage : Page
    {
        private double originalArticle;
        public EditProductPage(double article, string typeProduct, string nameProduct, double minCostPartner, double rollWidth)
        {
            InitializeComponent();
            LoadStateComboBox();

            //Я позже вынесу это в LoadOriginalValue
            ArticleTextBox.Text = article.ToString();
            NameTextBox.Text = nameProduct;
            MinCostPartnerTextBox.Text = minCostPartner.ToString();
            WidthTextBox.Text = rollWidth.ToString();

            TypeSelector.SelectedItem = typeProduct;
            originalArticle = article;
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
            string newArticle = ArticleTextBox.Text;
            string name = NameTextBox.Text;
            string typeProduct = TypeSelector.SelectedItem?.ToString();
            string minCostPartner = MinCostPartnerTextBox.Text;
            string rollWidth = WidthTextBox.Text; 

            if (string.IsNullOrEmpty(newArticle) || string.IsNullOrEmpty(name) || TypeSelector.SelectedItem == null
                || string.IsNullOrEmpty(minCostPartner) || string.IsNullOrEmpty(rollWidth))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            try
            {
                using (var db = new ApplicationContext())
                {
                    var productToUpdate = db.Products.FirstOrDefault(p => p.Article == originalArticle);
                    if (productToUpdate == null)
                    {
                        MessageBox.Show($"{originalArticle} не найден");
                        return;
                    }

                    productToUpdate.Article = Convert.ToDouble(newArticle);
                    productToUpdate.TypeProduct = typeProduct;
                    productToUpdate.NameProduct = name;
                    productToUpdate.MinCostPartner = Convert.ToDouble(minCostPartner);
                    productToUpdate.RollWidth = Convert.ToDouble(rollWidth);

                    db.Products.Update(productToUpdate);
                    db.SaveChanges();
                }
                MessageBox.Show("Продукт успешно изменен!");
                MainFrame.Navigate(new ProductsPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при измененение: {ex.Message}");
            }
        }

        private void Cancel_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProductsPage());
        }
    }
}
