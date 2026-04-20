using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private DateTime t1; // время запуска таймера
        private DateTime t2; // время срабатывания таймера

        public Form1()
        {
            InitializeComponent();

            // настройка компонентов numericUpDown
            numericUpDown1.Maximum = 59;
            numericUpDown1.Minimum = 0;
            // чтобы при появлении окна
            // курсор не мигал в поле редактирования
            numericUpDown1.TabStop = false;

            numericUpDown2.Maximum = 59;
            numericUpDown2.Minimum = 0;
            numericUpDown2.TabStop = false;

            // кнопка Пуск/Стоп не доступна
            button1.Enabled = false;
        }

        // обрабатывает событие ValueChanged от компонентов
        // numericUpDown1 и numericUpDown1
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if ((numericUpDown1.Value == 0) &&
                       (numericUpDown2.Value == 0))
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        // щелчок на кнопке Пуск/Стоп
        private void button1_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                // таймер не работает

                // t1 - текущее время
                // t2 = t1 + интервал
                t1 = new DateTime(DateTime.Now.Year,
                      DateTime.Now.Month, DateTime.Now.Day);
                t2 = t1.AddMinutes((double)numericUpDown1.Value);
                t2 = t2.AddSeconds((double)numericUpDown2.Value);

                groupBox1.Enabled = false;
                button1.Text = "Стоп";

                if (t2.Minute < 9)
                    label1.Text = "0" + t2.Minute.ToString() + ":";
                else
                    label1.Text = t2.Minute.ToString() + ":";

                if (t2.Second < 9)
                    label1.Text += "0" + t2.Second.ToString();
                else
                    label1.Text += t2.Second.ToString();

                // сигнал от таймера поступает каждую секунду
                timer1.Interval = 1000;

                // пуск таймера
                timer1.Enabled = true;

                groupBox1.Visible = false;
            }
            else
            {
                // таймер работает, останавливаем
                timer1.Enabled = false;
                button1.Text = "Пуск";
                groupBox1.Enabled = true;
                numericUpDown1.Value = t2.Minute;
                numericUpDown2.Value = t2.Second;
            }
        }


        // сигнал от таймера
        private void timer1_Tick(object sender, EventArgs e)
        {
            t2 = t2.AddSeconds(-1);

            if (t2.Minute < 9)
                label1.Text = "0" + t2.Minute.ToString() + ":";
            else
                label1.Text = t2.Minute.ToString() + ":";

            if (t2.Second < 9)
                label1.Text += "0" + t2.Second.ToString();
            else
                label1.Text += t2.Second.ToString();

            if (Equals(t1, t2))
            {
                timer1.Enabled = false;
                MessageBox.Show(
                    "Заданный интервал времени истек", "Таймер",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);

                
                button1.Text = "Пуск";
                groupBox1.Enabled = true;
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;
            }
        }
    }
}