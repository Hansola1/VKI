/*
 Программа работы с базой данных Microsoft Acces "Контакты" (contacts.mdb)
 Строка соединения загружается из файла конфигурации contacts_1.exe.config
 Демонстрирует использование команды SELECT с параметром для выборки
 информации из базы данных.
 
 (с) Nikita Kultin, 2008-2009
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

/* Пространство имен WindowsFormsApplication1.Properties
 * определено в файле Settings.Designer.cs,
 * который создает среда разработки в результате
 * формирования списка параметров на вкладке
 * Settings (команда Project>Properties)
 *
 * Список параметров программы:  
 *  -------------------------------------------------------------------------
 *       Name       |  Type   |     Scope   |      Value
 *  -------------------------------------------------------------------------
 *  ConnetionString | String  | Application | Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Database\Contacts.mdb
 *  -------------------------------------------------------------------------
 * 
 */



namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        // начало работы программы
        private void Form1_Load(object sender, EventArgs e)
        {
            // загрузить строку соединения из файла конфигурации
            oleDbConnection1.ConnectionString = Settings.Default.ConnectionString;
            
            // получить информацию из БД
            /* т.к. у команды SELECT есть параметр, который задает
               критерий отбора записей, то надо задать его значени */
            oleDbDataAdapter1.SelectCommand.Parameters[0].Value = "%%";
            oleDbDataAdapter1.Fill(dataTable1);
        }

        // завершение работы программы  
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

                oleDbDataAdapter1.Update(dataTable1);
            }
            catch (Exception e1)
        {
            MessageBox.Show(e1.ToString());
               
        }

            
        }

        // щелчок на кнопке Найти
        private void button1_Click(object sender, EventArgs e)
        {
            
            dataSet1.Clear(); // удалить старые данные
           
            // для получения информации из базы данных
            // используется команда SELECT с параметром:
            // SELECT *FROM сontacts WHERE (name Like ? )
            // где: ? - параметр
            // В программе доступ к параметру можно получить по номеру
            // или по имени.  
            
            // задать значение параметра команды SELECT
            // доступ по номеру
            //oleDbDataAdapter1.SelectCommand.Parameters[0].Value = "%" +  textBox1.Text + "%";

            // доступ к параметру по имени
            oleDbDataAdapter1.SelectCommand.Parameters["name"].Value = "%" + textBox1.Text + "%";

            // выполнить команду
            oleDbDataAdapter1.Fill(dataTable1);

        }

        
        // пользователь нажал клавишу <Delete>
        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult r;
            
            r= MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление записи",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (r == DialogResult.Cancel)
            {
                // отменить операцию удаления записи
                e.Cancel = true;
            }


        }

    }
}
