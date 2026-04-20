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
        public Form2 frm2;  //Объявляем Form2 и даем ей имя frm2
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
            frm2.label1.Text = "Привет";//Меняем текст
            this.Hide();//Прячем форму1

        }
    }
}
