using Microsoft.EntityFrameworkCore;
using Shop.DataControl;
using Shop.Models;
using Shop.ViewModels;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Shop.Views
{
    public partial class OrdersPage : Page
    {
        private bool _isPriceFilterActive = false;
        private CollectionViewSource _viewSource;
        private List<OrderView> _allOrders; 

        public OrdersPage()
        {
            InitializeComponent();
            _viewSource = new CollectionViewSource();
            LoadDataGrid();
        }

        public void LoadDataGrid() //сделать по авторизованным
        {
            using (var db = new ApplicationContext())
            {
                _allOrders = db.Orders 
                    .Include(p => p.Product)
                    .Select(o => new OrderView
                    {
                        ProductName = o.Product.product_name,
                        Price = o.Product.price,
                        OrderDate = o.order_date.ToString()
                    }).ToList();
            }
            OrdersDataGrid.ItemsSource = _allOrders;

            //_viewSource.Source = _allOrders; 
            //OrdersDataGrid.ItemsSource = _viewSource.View;
            //ApplyFilters(); 
        }

        //private void PriceFilterCheckBox_Checked(object sender, RoutedEventArgs e)
        //{
        //    _isPriceFilterActive = true;
        //    ApplyFilters();
        //}

        //private void PriceFilterCheckBox_Unchecked(object sender, RoutedEventArgs e)
        //{
        //    _isPriceFilterActive = false;
        //    ApplyFilters();
        //}

        //private void CostFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    ApplySorting("Price", GetSortDirection(CostFilter));
        //}

        //private void DateFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    ApplySorting("OrderDate", GetSortDirection(DateFilter));
        //}

        //private void ApplyFilters() //цена + поиск
        //{
        //    _viewSource.View.Filter = item =>
        //    {
        //        var order = (OrderView)item;
        //        bool priceFilter = !_isPriceFilterActive || order.Price > 29.999;
        //        bool searchFilter = string.IsNullOrEmpty(searchTextBox.Text) || order.ProductName.ToLower().Contains(searchTextBox.Text.ToLower());
        //        return priceFilter && searchFilter;
        //    };
        //}

        //private ListSortDirection GetSortDirection(ComboBox comboBox)
        //{
        //    string sortDirection = (comboBox.SelectedItem as ComboBoxItem)?.Tag as string;
        //    return sortDirection == "Ascending" ? ListSortDirection.Ascending : ListSortDirection.Descending;
        //}

        //private void ApplySorting(string propertyName, ListSortDirection direction)
        //{
        //    _viewSource.View.SortDescriptions.Clear();
        //    _viewSource.View.SortDescriptions.Add(new SortDescription(propertyName, direction));
        //}

        //private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    ApplyFilters(); // Применяем фильтры (включая поиск) при изменении текста
        //}
    }
}