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

            // файл справки
            helpProvider1.HelpNamespace = "npv.chm";
            helpProvider1.SetHelpNavigator(this, HelpNavigator.Topic);
            helpProvider1.SetShowHelp(this, true);

            // chm-файл получается путем компиляции htm-файлов,
            // в которых находится справочная информация.  
            // Обычно каждый раздел справочной информации
            // помещают в отдельный файл. В дальнейшем имя htm-файла
            // используется в качестве идентификатора раздела
            // справочной информации.

            // задать раздел справки 
            // для textBox1 - Финансовые результаты
            helpProvider1.SetHelpKeyword(textBox1, "npv_02.htm");
            helpProvider1.SetHelpNavigator(textBox1, HelpNavigator.Topic);
            helpProvider1.SetShowHelp(textBox1, true);


            // задать раздел справки 
            // для textBox2 - Финансовые затраты
            helpProvider1.SetHelpKeyword(textBox2, "npv_03.htm");
            helpProvider1.SetHelpNavigator(textBox2, HelpNavigator.Topic);
            helpProvider1.SetShowHelp(textBox2, true);

            // задать раздел справки 
            // для textBox3 - Ставка дисконтирования
            helpProvider1.SetHelpKeyword(textBox3, "npv_04.htm");
            helpProvider1.SetHelpNavigator(textBox3, HelpNavigator.Topic);
            helpProvider1.SetShowHelp(textBox3, true);


        }

        // щелчок на кнопке Расчет
        private void button1_Click(object sender, EventArgs e)
        {
            double p = 0; // поступления от продаж
            double r = 0; // расходы
            double d = 0; // ставка дисконтирования

            double npv = 0; // чистый дисконтированный доход

            try
            {
                p = Convert.ToDouble(textBox1.Text);
                r = Convert.ToDouble(textBox2.Text);
                d = Convert.ToDouble(textBox3.Text) / 100;

                npv = (p - r) / (1.0 + d);

                label4.Text = "Чистый дисконтированный доход (NPV) =  " +
                    npv.ToString("c");
            }
            catch 
            {
                //MessageBox.Show("Ощибка исходных данных", "Расчет NPV",
                //    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider1.HelpNamespace, "npv_01.htm");
        }

    }
}
