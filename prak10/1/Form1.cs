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
    public partial class Form1 : Form
    {
        //Добавляем экземпляр класса Random, он нам понадобиться для получения слуйчаной буквы.
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true; //Делаем таймер активным
            timer1.Start(); //Запускаем таймер 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
