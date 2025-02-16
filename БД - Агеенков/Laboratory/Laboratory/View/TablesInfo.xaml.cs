using System.Windows;
using System.Windows.Controls;
using Laboratory.DB;

namespace Laboratory.View
{
    public partial class TablesInfo : Page
    {
        private DBcontroller dbController;

        public TablesInfo()
        {
            InitializeComponent();

            dbController = new DBcontroller();
            dbController.LoadTables(TableListBox);
        }

        public void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void TableListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (TableListBox.SelectedItem != null)
            {
                string selectedTable = TableListBox.SelectedItem.ToString();
                dbController.LoadTableData(selectedTable, Work2_DataGrid);
            }
        }
    }
}
