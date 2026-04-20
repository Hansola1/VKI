/*
 Программа работы с базой данных Microsoft Acces "Контакты" (contacts.mdb)
 Строка соединения загружается из файла конфигурации 
 contacts_1.exe.config
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using WindowsFormsApplication1.Properties; // для доступа к объекту Settings

/* 
 Пространство имен WindowsFormsApplication1.Properties
 определено в файле Settings.Designer.cs,
 который формирует среда разработки в результате
 формирования списка параметров на вкладке
 Settings (команда Project>Properties)
 
 Список параметров программы:  
 -------------------------------------------
 Name             |  Type   |     Scope   |      Value
 -------------------------------------------
 ConnectionString | String  | Application | Provider=Microsoft.Jet.OLEDB.4.0;
                  |         |             | Data Source=D:\Database\Contacts.mdb
 ------------------------------------------- 
 */

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // загрузка формы - начало работы программы
        private void Form1_Load(object sender, EventArgs e)
        {
            // загрузить строку соединения из файла конфигурации
            oleDbConnection1.ConnectionString = Settings.Default.ConnectionString;
            
            // прочитать данные из БД
            oleDbDataAdapter1.Fill(dataTable1);
        }

        // завершение работы программы  
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            oleDbDataAdapter1.Update(dataSet1.Tables["contacts"]);
        }

        // пользователь выделил строку и нажал <Delete> 
        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr =
                  MessageBox.Show("Внимание!\nЗапись будет удалена из БД.\nВыполнить?",
                                  "Удаление записи",MessageBoxButtons.OKCancel,
                                  MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel )
            {
                e.Cancel = true;
            }
        }
    }
}
