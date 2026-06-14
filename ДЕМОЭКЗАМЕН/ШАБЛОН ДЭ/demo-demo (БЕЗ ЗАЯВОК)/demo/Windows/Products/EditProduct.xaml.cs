using demo.Data;
using demo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Media.Imaging;

namespace demo.Windows.Products
{
    public partial class EditProduct : Window
    {
        private readonly string projPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        DemoContext context;
        private Product product;
        private BitmapImage selectImage;
        private string? imageName = null;
        public EditProduct(Product product)
        {
            InitializeComponent();

            context = new DemoContext();
            this.product = product;
            Load();
        }

        private void Load()
        {
            BoxCategory.ItemsSource = context.Categories.ToList();
            BoxCategory.SelectedItem = product.Category;
            BoxSupplier.ItemsSource = context.Suppliers.ToList();
            BoxSupplier.SelectedItem = product.Supplier;
            BoxManufacturer.ItemsSource = context.Manufacturers.ToList();
            BoxManufacturer.SelectedItem = product.Manufacturer;
            BoxName.Text = product.Name.Name;
            BoxDescription.Text = product.Description;
            BoxDiscount.Text = product.Discount.ToString();
            BoxPrice.Text = product.Price.ToString();
            BoxUnit.Text = product.Unit.ToString();
            BoxCount.Text = product.Count.ToString();
        }

        private void ButtonSaveProduct(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BoxDescription.Text) ||
                string.IsNullOrWhiteSpace(BoxDiscount.Text) ||
                string.IsNullOrWhiteSpace(BoxName.Text) ||
                string.IsNullOrWhiteSpace(BoxPrice.Text) ||
                string.IsNullOrWhiteSpace(BoxUnit.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            try
            {
                product.Name = context.ProductNames.FirstOrDefault(q => q.Name == BoxName.Text) ?? new ProductName() { Id = context.ProductNames.Max(q => q.Id) + 1, Name = BoxName.Text };
                product.Category = context.Categories.FirstOrDefault(q => q.Name == BoxCategory.SelectedItem.ToString());
                product.Description = BoxDescription.Text;
                product.Manufacturer = context.Manufacturers.FirstOrDefault(q => q.Name == BoxManufacturer.SelectedItem.ToString());
                product.Supplier = context.Suppliers.FirstOrDefault(q => q.Name == BoxSupplier.SelectedItem.ToString());
                product.Price = int.Parse(BoxPrice.Text);
                product.Unit = BoxUnit.Text;
                product.Count = int.Parse(BoxCount.Text);
                product.Discount = int.Parse(BoxDiscount.Text);
                if (imageName != null)
                {
                    product.ImagePath = imageName;
                }

                context.Entry(product).State = EntityState.Modified;
                context.SaveChanges();

                DialogResult = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"не верный формат ввода {ex.Message}");
            }
        }

        private void ButtonExit(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void ButtonLoadImage(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == true)
            {
                Uri uri = new Uri(openFile.FileName);

                BitmapImage select = new(uri);
                if (select.Width > 400 || select.Height > 300)
                {
                    MessageBox.Show("Размеры изображения имеют не верный формат");
                    return;
                }

                File.Copy(Path.Combine(projPath, "Images"), openFile.FileName);

                selectImage = select;
                imageName = openFile.SafeFileName;
                BoxImage.Source = selectImage;
            }
        }
    }
}
