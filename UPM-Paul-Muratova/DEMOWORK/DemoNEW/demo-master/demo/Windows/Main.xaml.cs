using demo.Data;
using demo.Models;
using demo.UserControllers;
using demo.Windows.Products;
using demo.Windows.RequestWin;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Reflection;
using System.Transactions;
using System.Windows;
using System.Windows.Controls;

namespace demo.Windows
{
    public partial class Main : Window
    {
        private DemoContext context;
        private User currentUser;
        private List<Product> products;
        private readonly string projPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

        private string SortParam = "по возрастанию";
        private string FiltParam = "все поставщики";

        public Main()
        {
            context = new DemoContext();
            InitializeComponent();
            BoxUserName.Text = "гость";
            PanelFind.Visibility = Visibility.Collapsed;
            PanelBottomButton.Visibility = Visibility.Collapsed;
            DrawProductItem(products);
        }
        public Main(User user)
        {
            context = new DemoContext();
            InitializeComponent();

            BoxUserName.Text = user.FullName;
            currentUser = user;
            
            DrawProductItem(products);
            DrawSuppliers();

            if (user.RoleNavigation.Role1 == "Администратор")
            {
                BoxProduct.MouseDoubleClick += BoxProduct_MouseDoubleClick;
            }
            else
            {
                PanelBottomAdmin.Visibility = Visibility.Collapsed;
            }
        }

        public void DrawSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>()
            {
                new Supplier()
                {
                    Id = -1,
                    Name = "все поставщики",
                }
            };
            suppliers.AddRange(context.Suppliers.ToList());
            ComboBoxItem.ItemsSource = suppliers;
        }

        private void DrawProductItem(List<Product> product)
        {
            if(BoxProduct != null)
            {
                BoxProduct.Items.Clear();
                //BoxProduct.ItemsSource = product.Select(p => new ItemProduct(p));
                foreach (var item in products)
                {
                    if (item != null)
                    {
                        ItemProduct xml = new ItemProduct(item);

                        BoxProduct.Items.Add(xml);
                    }
                }
            }
        }

        private void Button_exit_user(object sender, RoutedEventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            this.Close();
        }

        private void BoxProduct_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ListBox list = sender as ListBox;
            ItemProduct controller = list.SelectedItem as ItemProduct;
            Product product = controller.DataContext as Product;
            EditProduct edit = new EditProduct(product);

            if (edit.ShowDialog() == true)
            {
                DrawProductItem(products);
            }
        }

        private void Button_add_product(object sender, RoutedEventArgs e)
        {
            AddProduct add = new AddProduct();
            if (add.ShowDialog() == true)
            {
                DrawProductItem(products);
            }
        }

        private void Button_request(object sender, RoutedEventArgs e)
        {
            RequestWindows request = new RequestWindows(currentUser);
            if (request.ShowDialog() == true)
            {

            }
        }

        //Поиск
        private void BoxFind_TextChanged(object sender, TextChangedEventArgs e)
        {
            Sort();
        }
        //Сортировка
        private void RadioUpp_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radio = sender as RadioButton;

            if (radio.Content.ToString() == "по возрастанию")
            {
                SortParam = "по возрастанию";
            }
            else if (radio.Content.ToString() == "по убыванию")
            {
                SortParam = "по убыванию";
            }
            Sort();
        }
        //Фильтрация
        private void ComboSuppliers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox box = sender as ComboBox;
            if (box.SelectedItem != null)
            {
                FiltParam = box.SelectedItem.ToString();
            }
            Sort();
        }

        public void Sort()
        {
            products = context.Products.Include(q => q.Supplier)
                .Include(q => q.Manufacturer)
                .Include(q => q.Name)
                .Include(q => q.Category)
                .ToList();

            products = products.Where(q =>
                (q.Description?.Contains(BoxFind.Text) ?? false)
                || (q.Article?.Contains(BoxFind.Text) ?? false)
                || (q.Name?.Name?.Contains(BoxFind.Text) ?? false)
                ).Where(q => q.Supplier.Name == FiltParam
                || FiltParam == "все поставщики").ToList();

            if (SortParam == "по возрастанию")
            {
                products = products.OrderBy(q => q.Count).ToList();
            }
            else if (SortParam == "по убыванию")
            {
                products = products.OrderByDescending(q => q.Count).ToList();
            }

            DrawProductItem(products);
        }

        private void Buutton_delite_product(object sender, RoutedEventArgs e)
        {
            Product prod = (Product)(BoxProduct.SelectedItem as ItemProduct).DataContext;
            if (prod != null)
            {
                var order = context.OrderArticles.FirstOrDefault(q => q.ProductId == prod.Id);

                if (order != null)
                {
                    MessageBox.Show("Продукт не можен быть удален, он участвует в заказе");
                    return;
                }
                context.Products.Remove(prod);
                context.SaveChanges();
                products = context.Products.ToList();
                DrawProductItem(products);
                if (prod.ImagePath != null)
                {
                    File.Delete(Path.Combine(projPath,"Images", prod.ImagePath));
                }
            }
            else
            {
                MessageBox.Show("Выберете продукт для удаления");
            }
        }
    }
}
