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
  public partial class AuthentificationForm : Form
  {
    public class AuthData
    {
        public string login { get; set; }
        public string password { get; set; }
    }

    public MainForm mForm;
    public AuthentificationForm()
    {
        InitializeComponent();
    }

    private void AuthentificationForm_Load(object sender, EventArgs e)
    {

    }

    

     private void button1_Click(object sender, EventArgs e)
    {
            string log = textBox1.Text;
            string pas = textBox2.Text;

    }

    private void AuthentificationForm_FormClosing(object sender, FormClosingEventArgs e)
    {

    }

    private void AuthentificationForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        mForm.Show();
        //this.Visible = false;
    }
    }
}
