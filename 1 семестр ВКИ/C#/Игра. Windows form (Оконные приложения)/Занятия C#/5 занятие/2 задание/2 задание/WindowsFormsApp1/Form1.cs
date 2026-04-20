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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Сохранение в файле
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            WriteToFile(filename, ЛУК);

        }

        private void WriteToFile(string path, ListBox listBox)
        {
            using (var sw = new StreamWriter(new FileStream(path, FileMode.Create)))
            {
                if (listBox != null)
                {
                    foreach (var item in listBox.Items) // в таком же порядке
                    {
                        sw.WriteLine(item.ToString());
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ЛУК.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ЛУК.Items.Remove("Горох");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ЛУК.Items.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
