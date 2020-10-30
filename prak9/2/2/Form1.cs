using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    Image MemForImage;

    // обработка кнопки меню "загрузка - в формате jpg"
    private void форматToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    private void выходToolStripMenuItem_Click(object sender, EventArgs e)
    {
      // создаем переменную rsl, которая будет хранить результат вывода окна с вопросом 
      // (пользователь нажал одну из клавиш на окне - это и есть результат)
      // MessageBox будет создержать вопрос, а так же кнопки Yes No и иконку Question (Вопрос)
      DialogResult rsl = MessageBox.Show("Вы действительно хотите выйти из приложения?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

      // если пользователь нажал кнопку да
      if (rsl == DialogResult.Yes)
      {
        // выходим из приложения
        Application.Exit();
      }
    }

    // обработка кнопки №1 на панели
    private void toolStripButton1_Click(object sender, EventArgs e)
    {

    }

    // обработка кнопки меню "загрузка - в формате png"
    private void форматPNGToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    // обработка кнопки №2 на панели
    private void toolStripButton2_Click(object sender, EventArgs e)
    {

    }

    // обработка кнопки №3 на панели
    private void toolStripButton3_Click(object sender, EventArgs e)
    {

    }

    // функция загрузки изображения
    private void LoadImage(bool jpg)
    {
      // директория, которая будет выбрана как начальная в окне для выбора файла openFileDialog1.InitialDirectory = "c:"; если будем выбирать jpg файлы
      if (jpg)
      {
        // устанавливаем формат файлов для загрузки - jpg
      }
    }
