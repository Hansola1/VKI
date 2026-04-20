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
        }

        // Обрабатывает нажатие клавиши в полях
        // редактирования Курс и Цена.
        // Сначала надо обычным образом создать фукцию
        // обработки события KeyPress для компонента
        // textBox1, затем - указать ее в качестве
        // обработчика этого же события для компонета textBox2
        private void textBox1_KeyPress(object sender,
                                KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;

            if (e.KeyChar == '.') e.KeyChar = ',';

            if (e.KeyChar == ',')
            {
                if ((textBox1.Text.IndexOf(',') != -1) ||
                      (textBox1.Text.Length == 0))
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (sender.Equals(textBox1))
                        // клавиша <Enter> нажата в поле Курс    
                        // переместить курсор в поле Цена
                        textBox2.Focus();
                    else
                        // клавиша <Enter> нажата в поле Цена    
                        // 
                        button1.Focus();
                }
                return;
            }

            // остальные символы запрещены
            e.Handled = true;
        }

        // изменился текст в поле редактирования
        // textBox1 или textBox2
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "";
            if ((textBox1.Text.Length == 0) || (textBox2.Text.Length == 0))
                // если какое-либо из полей не содержит
                // данных, то сделать недоступной кнопку OK 
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        // щелчок на кнопке OK
        private void button1_Click(object sender, EventArgs e)
        {
            double usd; // цена в долларах
            double k;   // курс

            double rub; // цена в рублях

            usd = Convert.ToDouble(textBox1.Text);
            k = Convert.ToDouble(textBox2.Text);

            rub = usd * k;

            label3.Text = rub.ToString("C"); // финансовый формат

        }

    }
}
