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
            comboBox1.DropDownStyle =
                ComboBoxStyle.DropDownList;

            // comboBox1.Items.Add("пластик");
            // comboBox1.Items.Add("алюминий");
            // comboBox1.Items.Add("бамбук");
            // comboBox1.Items.Add("соломка");
            // comboBox1.Items.Add("текстиль");

            comboBox1.SelectedIndex = 0;
        }

        // нажатие клавиши в поле редактирования
        // функция обрабатывает событие KeyPress
        // компонентов textBox1 и textBox2
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                    return;
/*
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
*/
                if (Char.IsControl(e.KeyChar))
                {
                    if (e.KeyChar == (char)Keys.Enter)
                    {
                        if (sender.Equals(textBox1))
                            // клавиша <Enter> нажата в поле Ширина   
                            // переместить курсор в поле Высота
                            textBox2.Focus();
                        else
                            // клавиша <Enter> нажата в поле Высота    
                            // переместить курсор в поле компонента ComboBox
                            comboBox1.Focus();
                    }
                    return;
                }

                // остальные символы запрещены
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((textBox1.Text.Length == 0) ||
                (textBox2.Text.Length == 0))
                 
                button1.Enabled = false;
            else
                button1.Enabled = true;

            label4.Text = "";
        }

        // щелчок на кнопке OK
        private void button1_Click(object sender, EventArgs e)
        {
            double w;
            double h;
            double cena = 0; // цена за 1 кв.м.
            double sum;

            w = Convert.ToDouble(textBox1.Text);
            h = Convert.ToDouble(textBox2.Text);

            switch (comboBox1.SelectedIndex)
            {
                case 0: cena = 50;  break; // пластик
                case 1: cena = 100; break; // алюминий
                case 2: cena = 75;  break; // бамбук
                case 3: cena = 70;  break; // соломка
                case 4: cena = 60;  break; // текстиь
            }

            sum = (w * h) / 10000 * cena;
            label4.Text =
                "Размер: " + w + "x" + h + " см.\n" +
                "Цена (р./м.кв.): " + cena.ToString("c") +
                "\nСумма: " + sum.ToString("c");
        }


        // в списке Материал пользователь
        // выбрал другой элемент
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = "";
        }
    }
}
