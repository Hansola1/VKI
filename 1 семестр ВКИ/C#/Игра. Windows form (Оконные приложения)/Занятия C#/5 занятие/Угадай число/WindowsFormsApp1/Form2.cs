using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form1 frm1;
        int c = 0;
        int k = 0;
        Random rnd = new Random();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm1 = new Form1();  //Создаем указатель на форму1
            int b, d = 0;
            bool f = true;
            string s = textBox1.Text;  // считываем число игрока

            try
            {//Проверка: вдруг не число
                d = Convert.ToInt32(s);
                c++;  //счет ходов
            }
            catch
            {
                textBox1.Text = "";
                f = false;
            }
            if (f)
            {  //Если число
                b = rnd.Next(1, 3);
                if (d == b)
                {
                    k++;  //Счет совпадений
                }
                s = s + " - " + b.ToString();
                listBox1.Items.Add(s);
            }
            if (c == 5)  //Всего пять ходов
            {
                textBox1.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
