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
    public partial class Port : Form
    {
        public static Config config;
        public MainForm mForm;
        public Port()
        {
            InitializeComponent();
        }

        private void Port_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            config._Port = textBox1.Text;
            MessageBox.Show("Вы поменяли порт.", "Cute chat :3", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mForm.Show();
            this.Visible = false;
        }
        private void Port_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void Port_FormClosed(object sender, FormClosedEventArgs e)
        {
            mForm.Show();
            //this.Visible = false;
        }
    }
}
