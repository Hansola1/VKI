using ElectricalProfiling.Model;
using ElectricalProfiling.Model.DB;
using ElectricalProfiling.Model.ViewModel;
using ElectricalProfiling.Views.UseControll;
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
                DrawChart(selectedMeasurement);
            }
        }

        private void DrawChart(MeasurementView selectedMeasurement)
        {
            MeasurementsCanvas.Children.Clear(); // Очистить Canvas перед рисованием

            // Пример данных для каждого типа измерения
            List<double> dataPoints = new List<double>();
            string measurementType = selectedMeasurement.MeasurementType;

            // Заполняем данные в зависимости от типа измерения
            if (measurementType == "Температура")
            {
                // Примерные данные для температуры
                dataPoints = new List<double> { 20, 22, 23, 21, 19, 18, 20 };
            }
            else if (measurementType == "Давление")
            {
                // Примерные данные для давления
                dataPoints = new List<double> { 1013, 1015, 1012, 1010, 1013, 1014 };
            }
            else if (measurementType == "Влажность")
            {
                // Примерные данные для влажности
                dataPoints = new List<double> { 60, 62, 65, 70, 75, 80 };
            }
            else
            {
                MessageBox.Show("Неизвестный тип измерения.");
                return;
            }

            // Параметры графика
            double canvasWidth = MeasurementsCanvas.ActualWidth;
            double canvasHeight = MeasurementsCanvas.ActualHeight;
            double maxDataValue = dataPoints.Max();
            double minDataValue = dataPoints.Min();

            // Масштабирование данных
            double scaleX = canvasWidth / (dataPoints.Count - 1);  // Расстояние по оси X
            double scaleY = canvasHeight / (maxDataValue - minDataValue);  // Масштаб по оси Y

            // Создание линии для графика
            Polyline graphLine = new Polyline
            {
                Stroke = Brushes.Blue,
                StrokeThickness = 2
            };

            // Добавление точек на график
            for (int i = 0; i < dataPoints.Count; i++)
            {
                double x = i * scaleX;  // Координата по X
                double y = canvasHeight - (dataPoints[i] - minDataValue) * scaleY;  // Координата по Y
                graphLine.Points.Add(new Point(x, y));
            }

            // Добавление линии на Canvas
            MeasurementsCanvas.Children.Add(graphLine);
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
