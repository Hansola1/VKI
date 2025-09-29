using OurDecorApplication.DataControl;
using OurDecorApplication.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace OurDecorApplication.Views
{
    public partial class MaterialsPage : Page
    {
        public MaterialsPage()
        {
            InitializeComponent();
            LoadListView();
        }

        List<MaterialView> materials = new();
        public void LoadListView()
        {
            using (var db = new ApplicationContext())
            {
                materials = db.Materials.Select(s => new MaterialView
                {
                    NameMaterial = s.NameMaterial,
                    TypeMaterialId = s.TypeMaterialId,
                    TypeMaterial = s.TypeMaterial,
                    CostMaterialOne = s.CostMaterialOne,
                    CountMaterial = s.CountMaterial,
                    MinCount = s.MinCount,
                    CountInPackage = s.CountInPackage,
                    UnitMeasurement = s.UnitMeasurement
                }).ToList();

                MaterialsListView.ItemsSource = materials;
            }
        }

        private void ToProducts_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProductsPage());
        }

        private void Cancel_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MainPage());
        }
    }
}
