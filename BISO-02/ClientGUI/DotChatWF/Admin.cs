using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotChatWF
{
    public partial class Admin : Form
    {
        public MainForm mForm;
        public string secret = "Поставьте 5";
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=secret)
                MessageBox.Show("Неправильное волшебное слово.", "Попытка обмана!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                if((Int16.Parse(textBox2.Text) > (mForm.lastMsgID-1))||(Int16.Parse(textBox2.Text) < 0))
                MessageBox.Show("Не существует такого сообщения.", "Ложное удаление!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
    }
}
