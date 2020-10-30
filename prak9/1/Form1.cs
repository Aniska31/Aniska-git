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

    Random rnd = new Random();
    Point tmp_location;

    int _w = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width;
    int _h = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height;

    private void label1_Click(object sender, EventArgs e)
        {

        }

    private void button1_Click(object sender, EventArgs e)
    {
      // Вывести сообщение с текстом "Вы усердны"
      MessageBox.Show("Молодца, знал, что ты правильный человек!", "Я в тебя всегда верил", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      // Завершить приложение
      Application.Exit();
    }

    private void Form1_MouseMove(object sender, MouseEventArgs e)
    {
      // переводим координату X в строку и записывает в поля ввода
     OX.Text = e.X.ToString();
      // переводим координату Y в строку и записывает в поля ввода
     OY.Text = e.Y.ToString();

      if (e.X > 70 && e.X < 170 && e.Y > 320 && e.Y < 365)
      {
        tmp_location = this.Location;
        tmp_location.X += rnd.Next(-100, 100);
        tmp_location.Y += rnd.Next(-100, 100);

        if (tmp_location.X < 0 || tmp_location.X > (_w - this.Width / 2) || tmp_location.Y < 0 || tmp_location.Y > (_h - this.Height / 2))
        {
          tmp_location.X = _w / 2;
          tmp_location.Y = _h / 2;
        }

        this.Location = tmp_location;
      }
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
