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
    public partial class Form1 : Form
    {
        public Form2 frm2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm2 = new Form2();//Создаем указатель на форму2
            frm2.frm1 = this;//Передаем форме2 указатель на форму1
            frm2.BackColor = Color.Cyan;//Меняем цвет формы2
            frm2.Show();//Показываем форму2
            frm2.label1.Text = textBox1.Text + "  " + textBox2.Text + "!  Поиграем?";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();//Конец игры
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
