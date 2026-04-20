using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileDialog_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Чтение из файла в TextBox
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                string fileText = File.ReadAllText(filename);
                textBox1.Text = fileText;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Запись из TextBox в файл
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|Allfiles(*.*) | *.* ";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, textBox1.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] vegetables = { "ПОМИДОРЫ", "КАБАЧКИ", "ЧЕСНОК" };
            listBox1.Items.AddRange(vegetables);
            listBox1.Items.Insert(1, "ЗЕЛЕНЬ");
            listBox1.Items.Remove("КАБАЧКИ");
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
