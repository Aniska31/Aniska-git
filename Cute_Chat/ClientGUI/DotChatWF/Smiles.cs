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
    public partial class Smiles : Form
    {

        public MainForm mForm;
        public Smiles()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sm = mForm.TextBox_text.Text;
            string ch = "🌻";
            sm = sm + ch;
            mForm.TextBox_text.Text = sm;
            mForm.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sm = mForm.TextBox_text.Text;
            string ch = "🌺";
            sm = sm + ch;
            mForm.TextBox_text.Text = sm;
            mForm.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sm = mForm.TextBox_text.Text;
            string ch = "🌵";
            sm = sm + ch;
            mForm.TextBox_text.Text = sm;
            mForm.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sm = mForm.TextBox_text.Text;
            string ch = "🌲";
            sm = sm + ch;
            mForm.TextBox_text.Text = sm;
            mForm.Show();
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sm = mForm.TextBox_text.Text;
            string ch = "🍀";
            sm = sm + ch;
            mForm.TextBox_text.Text = sm;
            mForm.Show();
            this.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sm = mForm.TextBox_text.Text;
            string ch = "💕";
            sm = sm + ch;
            mForm.TextBox_text.Text = sm;
            mForm.Show();
            this.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string sm = mForm.TextBox_text.Text;
            string ch = "🍒";
            sm = sm + ch;
            mForm.TextBox_text.Text = sm;
            mForm.Show();
            this.Visible = false;
        }
    }
}
