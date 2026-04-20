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
        public Form1 frm1;  //Объявляем Form1 и даем ей имя frm1

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm1 = new Form1();
            frm1.label1.Text = "Ответ";
            this.Hide();//Прячем форму2
            frm1.Show();//Показывем форму1

        }
    }
}
