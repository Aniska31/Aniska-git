using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotChatWF
{
  public partial class AuthentificationForm : Form
  {
        public static Config config;
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
            try
            {
                config = IMainFunction.FromJsonFile<Config>("config.json");

            }
            catch
            {
                config = new Config()
                {
                    _Port = "5000"//5000
                };
                IMainFunction.ToJsonFile("config.json", config);
            }
        }

    

     private void button1_Click(object sender, EventArgs e)
    {
            WebRequest req = WebRequest.Create("http://localhost:"+config._Port+"/api/auth");
            //WebRequest req = WebRequest.Create("http://localhost:5000/api/auth");
            req.Method = "POST";
            AuthData auth_data = new AuthData();
            auth_data.login = textBox1.Text;
            auth_data.password = textBox2.Text;
            string postData = JsonConvert.SerializeObject(auth_data);
            req.ContentType = "application/json";
            StreamWriter reqStream = new StreamWriter(req.GetRequestStream());
            reqStream.Write(postData);
            reqStream.Close();
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            StreamReader sr = new StreamReader(resp.GetResponseStream(), Encoding.GetEncoding("utf-8"));
            string content = sr.ReadToEnd();
            sr.Close();
            int int_token = Convert.ToInt32(content, 10);
            if ((int_token != -1)&& (int_token != -2)&& (int_token != -200))
            {
                mForm.int_token = int_token;
                mForm.TextBox_username.Text = auth_data.login;;
                MessageBox.Show("Вы авторизовались. Приятного общения :)", "Cute chat :3", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mForm.Show();
                this.Visible = false;
            }
            else
                if (int_token == -1)
                    MessageBox.Show("Неправильно введен пароль.Повторите еще раз.", "Ошибка при авторизации", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    if ( int_token == -2)
                MessageBox.Show("Такого пользователя не существует.Повторите еще раз.", "Ошибка при авторизации", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                         MessageBox.Show("Ошибка логики.", "Ошибка при авторизации", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
