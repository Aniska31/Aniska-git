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
    public partial class Admin : Form
    {
        public MainForm mForm;
        public static Config config;
        public string secret = "1";
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
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
            if(textBox1.Text!=secret)
                MessageBox.Show("Неправильное волшебное слово.", "Попытка обмана!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                if((Int16.Parse(textBox2.Text) > (mForm.lastMsgID-1))||(Int16.Parse(textBox2.Text) < 0))
                    MessageBox.Show("Не существует такого сообщения.", "Ложное удаление!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                WebRequest req = WebRequest.Create("http://localhost:" + config._Port + "/api/del");
                //WebRequest req = WebRequest.Create("http://localhost:5000/api/reg");
                req.Method = "POST";
                int id_ms = Int16.Parse(textBox2.Text);
                string postData = JsonConvert.SerializeObject(id_ms);
                req.ContentType = "application/json";
                StreamWriter reqStream = new StreamWriter(req.GetRequestStream());
                reqStream.Write(postData);
                reqStream.Close();
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                StreamReader sr = new StreamReader(resp.GetResponseStream(), Encoding.GetEncoding("utf-8"));
                string content = sr.ReadToEnd();
                sr.Close();
                mForm.lastMsgID--;
                MessageBox.Show("Сообщение успешно удалено!", "Cute chat :3", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
