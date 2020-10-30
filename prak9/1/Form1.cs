using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
  public partial class Best_Form : Form
  {
    public Best_Form()
    {
      InitializeComponent();
    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    private void button1_Click(object sender, EventArgs e)
    {
      // Вывести сообщение с текстом "Вы усердны"
      MessageBox.Show("Вы усердны!!");
      // Завершить приложение
      Application.Exit();
    }

    private void Form1_MouseMove(object sender, MouseEventArgs e)
    {
      // переводим координату X в строку и записывает в поля ввода
      OX.Text = e.X.ToString();
      // переводим координату Y в строку и записывает в поля ввода
      OY.Text = e.Y.ToString();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void OX_TextChanged(object sender, EventArgs e)
    {

    }

    private void No_Click(object sender, EventArgs e)
    {
      // Вывести сообщение, с текстом "Мы не сомневались в вешем безразличии" второй параметр - заголовок окна сообщения "Внимание"
      //MessageBoxButtons.OK; - тип размещаемой кнопки на форме сообщения
      //MessageBoxIcon.Information; - тип сообщения - будет иметь иконку "информация" и соответствующий звуковой сигнал 
      MessageBox.Show("Я записал тебя в список плохих людей, но пока что только карандашом.", "Ты так не глупи...",MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
  }
}
