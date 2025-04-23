using ElectricalProfiling.Model;
using ElectricalProfiling.Model.DB;
using ElectricalProfiling.Model.ViewModel;
using ElectricalProfiling.Views.UseControll;
using LiveCharts.Wpf;
using LiveCharts;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ElectricalProfiling.Views
{
    public partial class MeasurementsPage : Page
    {
        public MeasurementsPage()
        {
            InitializeComponent();
            LoadMeasurements();
            LoadComboBox();
        }

        private List<MeasurementView> measurements = new List<MeasurementView>();
        public void LoadMeasurements()
        {
            using (var db = new ApplicationContext())
            {
                measurements = db.Measurement.ToList()
                    .Select(measurement =>
                    {
                        var station = db.Stations.FirstOrDefault(s => s.ID == measurement.Station_ID);

                        return new MeasurementView
                        {
                            StationName = station?.station_name ?? "Неизвестно",
                            MeasurementDate = measurement.Date ?? DateTime.MinValue,
                            MeasurementType = measurement.measurement_type ?? "Неизвестно",
                            Value = measurement.Value ?? 0.0,
                            Unit = measurement.Units ?? "Неизвестно",
                            ID = measurement.ID
                        };
                    }).ToList();
            }

            Measurements_DataGrid.ItemsSource = measurements;
        }
        public void LoadComboBox()
        {
            MeasurementsSelector.ItemsSource = measurements; 
            MeasurementsSelector.DisplayMemberPath = "MeasurementType";  
            MeasurementsSelector.SelectedValuePath = "ID";   

            if (measurements.Any())
            {
                MeasurementsSelector.SelectedIndex = 0;
            }
        }

        private void TypeMeasurementsSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MeasurementsSelector.SelectedItem is MeasurementView selectedMeasurement)
            {
                DrawChart(selectedMeasurement.MeasurementType);
            }
        }


        private void DrawChart(string measurementType)
        {
            using (var db = new ApplicationContext())
            {
                var measurements = db.Measurement
                    .Where(m => m.measurement_type == measurementType)
                    .OrderBy(m => m.Date)
                    .ToList();

                var values = new ChartValues<double>(measurements.Select(m => m.Value ?? 0));
                var labels = measurements.Select(m => m.Date?.ToShortDateString() ?? "").ToArray();

                MeasurementsChart.Series = new SeriesCollection
                {
                    new ColumnSeries
                    {
                        Title = measurementType,
                        Values = values
                    }
                };

                MeasurementsChart.AxisX.Clear();
                MeasurementsChart.AxisX.Add(new Axis
                {
                    Title = "Дата",
                    Labels = labels.ToList()
                });

                MeasurementsChart.AxisY.Clear();
                MeasurementsChart.AxisY.Add(new Axis
                {
                    Title = "Значение",
                    LabelFormatter = value => value.ToString("N2")
                });
            }
        }


        private void DeleteMeasurement_Click(object sender, RoutedEventArgs e)
        {
            var selectedMeasurement = Measurements_DataGrid.SelectedItem as MeasurementView;
            if (selectedMeasurement != null)
            {
                using (var db = new ApplicationContext())
                {
                    var measurementToDelete = db.Measurement.FirstOrDefault(m => m.ID == selectedMeasurement.ID);
                    if (measurementToDelete != null)
                    {
                        db.Measurement.Remove(measurementToDelete);
                        db.SaveChanges();

                        MessageBox.Show("Измерение успешно удалено!");
                        LoadMeasurements();
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите измерение для удаления");
            }
        }
        private void AddMeasurement_Click(object sender, RoutedEventArgs e)
        {
            var addMeasurementsControl = new AddMeasurements();
            MainGrid.Children.Add(addMeasurementsControl);

            addMeasurementsControl.HorizontalAlignment = HorizontalAlignment.Center;
            addMeasurementsControl.VerticalAlignment = VerticalAlignment.Center;
        }


        private void Out_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void OpenProject_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProjectPage());
        }
        private void OpenProfile_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProfilePage());
        }
        private void OpenArea_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AreasPage());
        }
        private void OpenStations_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new StationsPage());
        }
        private void OpenMeasurements_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MeasurementsPage());
        }
    }
}
