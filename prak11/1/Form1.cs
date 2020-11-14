
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        // строка подключения к MS Access
        // вариант 1
        //public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Workers.mdb;";
        // вариант 2
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Workers.mdb;";

        // поле - ссылка на экземпляр класса OleDbConnection для соединения с БД
        private OleDbConnection myConnection;
        public Form1()
        {
            InitializeComponent();
            // создаем экземпляр класса OleDbConnection
            myConnection = new OleDbConnection(connectString);
            // открываем соединение с БД
            myConnection.Open();
        }

        /*// обработчик события закрытия формы
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // заркываем соединение с БД
            myConnection.Close();
        }*/

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // обработчик нажатия кнопки SELECT1
        private void button1_Click(object sender, EventArgs e)
        {
            // текст запроса
            string query = "SELECT w_name FROM Worker WHERE w_salary > 20000";
            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);
            // выполняем запрос и выводим результат в textBox1
            textBox1.Text = command.ExecuteScalar().ToString();
        }

        // обработчик нажатия кнопки SELECT2
        private void button2_Click(object sender, EventArgs e)
        {
            // текст запроса
            string query = "SELECT w_name, w_position, w_salary FROM Worker ORDER BY w_salary";
            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);
            // получаем объект OleDbDataReader для чтения табличного результата запроса SELECT
            OleDbDataReader reader = command.ExecuteReader();
            // очищаем listBox1
            listBox1.Items.Clear();
            // в цикле построчно читаем ответ от БД
            while (reader.Read())
            {
                // выводим данные столбцов текущей строки в listBox1
                listBox1.Items.Add(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString() + " ");
            }
            // закрываем OleDbDataReader
            reader.Close();
        }

        // обработчик нажатия кнопки INSERT
        private void button3_Click(object sender, EventArgs e)
        {
            // текст запроса
            string query = "INSERT INTO Worker (w_name, w_position, w_salary) VALUES ('Валера', 'Технолог UWP', 40000)";
            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);
            // выполняем запрос к MS Access
            command.ExecuteNonQuery();
        }

        // обработчик нажатия кнопки UPDATE
        private void button4_Click(object sender, EventArgs e)
        {
            // текст запроса
            string query = "UPDATE Worker SET w_salary = 123456 WHERE w_id = 3";
            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);
            // выполняем запрос к MS Access
            command.ExecuteNonQuery();
        }

        // обработчик нажатия кнопки DELETE
        private void button5_Click(object sender, EventArgs e)
        {
            // текст запроса
            string query = "DELETE FROM Worker WHERE w_id < 3";
            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);
            // выполняем запрос к MS Access
            command.ExecuteNonQuery();
        }

        // обработчик события закрытия формы
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // заркываем соединение с БД
            myConnection.Close();
        }
    }
}
