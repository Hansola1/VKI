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

            // настройка компонентов
            radioButton1.Checked = true;
            button1.Enabled = false;
        }

        // щелчок на кнопке OK
        private void button1_Click(object sender, EventArgs e)
        {
            double cena = 0 ; // цена
            int n;            // кол-фо фотографий
            double sum;       // сумма

            if (radioButton1.Checked)
                cena = 8.50;
            if (radioButton2.Checked)
                cena = 10;
            if (radioButton3.Checked)
                cena = 15.5;

            n = Convert.ToInt32(textBox1.Text);
            sum = n * cena;

            label2.Text = "Цена: " + cena.ToString("c") +
                "\nКоличество: " + n.ToString() + "шт.\n" +
                "Сумма заказа: " + sum.ToString("C");
        }

        // В поле Количество можно ввести только целое число
        private void textBox1_KeyPress(object sender,
                                       KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    // нажата клавиша <Enter>    
                    button1.Focus();
                }
                return;
            }    
            // остальные символы запрещен
            e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                button1.Enabled = false;
            else
                button1.Enabled = true;
            
            label2.Text = "";
        }

        // щелчок на radioButton
        private void radioButton1_Click(object sender, EventArgs e)
        {
            label2.Text = "";  
            // установить курсор в поле Количество
            textBox1.Focus();
        }
    }
}
