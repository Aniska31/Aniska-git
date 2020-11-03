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
        int balance = 100; //Исходный баланс.
        int counter_money = 0; //Текущий ставка.
        int counter_try = 0; //Счетчик попыток.
        int win_money = 0; //Выигранные деньги.
        bool IsActive = true; //Активность кнопки "Погнали!"
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
