using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//меню
namespace Game
{
    public partial class Form1 : Form
    {
        public Form2 frm2;  //Объявляем Form2 и даем ей имя frm2
        public Form3 frm3;  //Объявляем Form3 и даем ей имя frm3
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm2 = new Form2(); //Создаем указатель на форму2
            frm2.frm1 = this; //Передаем форме2 указатель на форму1
            frm2.Show(); //Показываем форму2
            this.Hide();//Прячем форму1

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm3 = new Form3(); //Создаем указатель на форму2
            frm3.frm1 = this; //Передаем форме3 указатель на форму1
            frm3.Show(); //Показываем форму3
            this.Hide();//Прячем форму1
        }
    }
}
