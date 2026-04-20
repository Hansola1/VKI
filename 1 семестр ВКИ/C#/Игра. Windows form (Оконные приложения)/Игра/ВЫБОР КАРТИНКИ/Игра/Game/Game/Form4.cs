using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form4 : Form
    {
        public Form1 frm1;  //Объявляем Form1 и даем ей имя frm1
        public Form2 frm2;  //Объявляем Form2 и даем ей имя frm2
        public Form3 frm3;  //Объявляем Form3 и даем ей имя frm3
        

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm2 = new Form2(); //Создаем указатель на форму2
            //frm2.frm4 = this;
            //frm2.Show(); //Показываем форму2
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
