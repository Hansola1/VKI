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
        public Form1()
        {
            InitializeComponent();

            button1.Enabled = false;
        }
        
        // нажатие клавиши в поле редактирования
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;

            if (e.KeyChar == '.')

                e.KeyChar = ',';

            if (e.KeyChar == ',')
            {
                // в поле редактирования не может
                // быть больше одной запятой и запятая
                // не может быть первым символом
                if ((textBox1.Text.IndexOf(',') != -1) ||
                      (textBox1.Text.Length == 0))
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // установить курсор на кнопку OK
                    button1.Focus();
                return;
            }
            // остальные символы запрещены
            e.Handled = true;
        }

        // изменилось содержимое поля редактирования
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        // щелчок на кнопке Добавить
        private void button1_Click(object sender, EventArgs e)
        {
            double kurs;   // курс
            DateTime date; //
      
            date = dateTimePicker1.Value;
            kurs =  System.Convert.ToDouble(textBox1.Text);
           
            // получить информацию о файле
            System.IO.FileInfo fi =
                    new System.IO.FileInfo(
                            Application.StartupPath + "\\usd.txt");

            // поток для записи        
            System.IO.StreamWriter sw;
           
            if (fi.Exists) // файл данных существует?
                // откроем поток для добавления
                sw = fi.AppendText();
            else
                // создать файл и открыть поток для записи
                sw = fi.CreateText();
    
            // запись в файл
            sw.WriteLine(date.ToShortDateString());
            sw.WriteLine(kurs.ToString("N"));
      
            // закрыть поток
            sw.Close();

            // чтобы по ошибке не записать данные
            // второй раз, сделаем недоступным поле
            // ввода и кнопку
            button1.Enabled = false;
            textBox1.Enabled = false;
         }

        // пользователь выбрал другую дату
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // очистить и сделать доступным
            // поле ввода
            textBox1.Enabled = true;
            textBox1.Clear();
            // установить курсор в поле ввода
            textBox1.Focus();
        }
    }
}
