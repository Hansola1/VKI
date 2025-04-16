using ElectricalProfiling.Model;
using ElectricalProfiling.Model.DB;
using System.Windows;
using System.Windows.Controls;

namespace ElectricalProfiling.Views.UseControll
{
    public partial class AddMeasurements : UserControl
    {
        public AddMeasurements()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string stationName = StantionName_TextBox.Text;
            string dateText = Date_TextBox.Text;
            string measurementType = MeasurementType_TextBox.Text;
            string valueText = Value_TextBox.Text;
            string valueUnits = ValueUnits_TextBox.Text;

            if (string.IsNullOrWhiteSpace(stationName) || string.IsNullOrWhiteSpace(dateText) ||
                string.IsNullOrWhiteSpace(measurementType) || string.IsNullOrWhiteSpace(valueText) ||
                string.IsNullOrWhiteSpace(valueUnits))
            {
                MessageBox.Show("Все поля должны быть заполнены.");
                return;
            }

            if (!DateTime.TryParse(dateText, out DateTime date))
            {
                MessageBox.Show("Неверный формат даты.");
                return;
            }
            if (!double.TryParse(valueText, out double value))
            {
                MessageBox.Show("Неверный формат значения.");
                return;
            }

            using (var db = new ApplicationContext())
            {
                var station = db.Stations.FirstOrDefault(s => s.station_name == stationName);
                if (station == null)
                {
                    MessageBox.Show($"Профиль '{stationName}' не найден");
                    return;
                }

                var measurement = new Measurements
                {
                    Station_ID = station.ID,
                    Date = date,
                    measurement_type = measurementType,
                    Value = Convert.ToInt32(value),
                    Units = valueUnits
                };
                db.Measurement.Add(measurement);
                db.SaveChanges();

                MessageBox.Show("Измерение успешно добавлено!");
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            var parent = Parent as Panel;
            parent?.Children.Remove(this);
        }
    }
}
