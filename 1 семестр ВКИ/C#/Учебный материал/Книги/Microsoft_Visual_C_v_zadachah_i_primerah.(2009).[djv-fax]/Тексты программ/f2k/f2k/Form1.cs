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

            // сделать кнопку OK недоступной
            button1.Enabled = false;
        }

        // нажатие клавиши в поле редактирования
        private void textBox1_KeyPress(object sender,
                                KeyPressEventArgs e)
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
                if ( (textBox1.Text.IndexOf(',') != -1) ||
                      ( textBox1.Text.Length == 0))
                {
                    e.Handled = true;
                }
                return;
            }

            if (  Char.IsControl (e.KeyChar) )
            {
                // <Enter>, <Backspace>, <Esc>
                if ( e.KeyChar == (char) Keys.Enter)
                    // установить курсор на кнопку OK
                    button1.Focus(); 
                return;
            }

            // остальные символы запрещены
            e.Handled = true;
        }

        // текст в поле редактирования изменился
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = ""; // очистить поле отображения
                              // результата расчета

            if (textBox1.Text.Length == 0)
                // в поле редактирования нет данных
                // сделать кнопку OK недоступной
                button1.Enabled = false;
            else
                // сделать кнопку OK доступной
                button1.Enabled = true;

        }

        // щелчок на кнопке OK
        private void button1_Click(object sender, EventArgs e)
        {
            double funt; // вес в фунтах
            double kg;   // вес в килограммах

            funt = Convert.ToDouble(textBox1.Text);

            // 1 фунт = 409,5 грамма
            kg = funt * 0.4095;

            label2.Text = funt.ToString("N") + " ф. = "
                             + kg.ToString("N") + " кг.";
        }

   }    
}
