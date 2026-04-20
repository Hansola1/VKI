using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//using System.Globalization;
// System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator 

namespace m2k
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // нажатие клавиши в поле редактирования
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Правильными символами считаются цифры,
            // запятая, <Enter> и <Backspace>.
            // Будем считатьать правильным символом
            // также точку, на заменим ее запятой.
            // Остальные символы запрещены.
            // Чтобы запрещенный символ не отображался 
            // в поле редактирования,присвоим 
            // значение true свойству Handled параметра e

            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }

            if (e.KeyChar == '.')
            {
                // точку заменим запятой
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (textBox1.Text.IndexOf(',') != -1)
                {
                    // запятая уже есть в поле редактирования
                    e.Handled = true;
                }
                return;
            }

            if (  Char.IsControl (e.KeyChar) )
            {
                // <Enter>, <Backspace>, <Esc>
                if ( e.KeyChar == (char) Keys.Enter)
                    // нажата клавиша <Enter>
                    // установить курсор на кнопку OK
                    button1.Focus(); 
                return;
            }

            // остальные символы запрещены
            e.Handled = true;
        }


        // щелчок на кнопке OK
        private void button1_Click(object sender, EventArgs e)
        {
            double mile; // расстояние в миля
            double km;   // расстояние в километрах

            // Если в поле редактирования нет данных,
            // то при попытке преобразовать пустую
            // строку в число возникает исключение.
            try
            {
                mile = Convert.ToDouble(textBox1.Text);

                km = mile * 1.609344; 

                label2.Text = km.ToString("n") // числовой (numeric) формат
                              + " км.";             
            }
            catch
            {
                // обработка исключения:
                // переместить курсор в поле редактирования
                textBox1.Focus();
            }
        }
    }
}
