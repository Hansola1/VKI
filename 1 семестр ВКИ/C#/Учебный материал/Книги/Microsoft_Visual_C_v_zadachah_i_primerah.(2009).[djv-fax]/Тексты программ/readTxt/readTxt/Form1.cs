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
        }

        // щелчок на кнопке OK
        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader sr; // поток для чтения 
            try
            {
                // создать поток для чтения
                sr = new System.IO.StreamReader(
                    Application.StartupPath + "\\usd.txt",
                        System.Text.Encoding.GetEncoding(1251));
                
                // начало и конец интервала, выделенного
                // на календаре
                DateTime dateStart = monthCalendar1.SelectionStart;
                DateTime dateEnd = monthCalendar1.SelectionEnd;
                
                string st1,st2 = ""; // строки, прочитанные из файла
                DateTime date;

                listBox1.Items.Clear();

                 // читаем данные из файла
                while ( ! sr.EndOfStream )
                {
                    st1 = sr.ReadLine(); // дата как строка
                    date = System.Convert.ToDateTime(st1);
                    st2 = sr.ReadLine(); 

                    if ((date >= dateStart) && (date <= dateEnd))
                    {
                        listBox1.Items.Add(st1 + "   " + st2);
                    }
                }
                sr.Close();

                if (listBox1.Items.Count == 0)
                {
                    listBox1.Items.Add("--- нет данных ---");
                }
            }
            
            catch(Exception exc)
            {
                MessageBox.Show("Ошибка доступа к файлу данных\n" +
                    exc.ToString(),
                    "Котировки",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                button1.Enabled = false;
            }
        }
  }        
}

