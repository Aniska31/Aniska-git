using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Text.Json;

namespace DotChatWF
{

    public struct Config
    {
        public int _Update_rate { get; set; }
        public int _Height { get; set; }
        public int _Width { get; set; }
        public string _Port { get; set; }

        public override string ToString()
        {
            return System.Text.Json.JsonSerializer.Serialize<Config>(this, new JsonSerializerOptions() { WriteIndented = true });
        }
    }

    public partial class MainForm : Form
    {

        
        // Глобальные переменные
        
        public int lastMsgID = 0;
        public int copyID;
        AuthentificationForm AuthForm;
        RegistartionForm RegForm;
        Port PForm;
        Smiles SmileForm;
        Admin AForm;
        public TextBox TextBox_username;
        public TextBox TextBox_text;
        public int int_token;
        public Message messages;
        public static Config config;



        public MainForm()
        {
            InitializeComponent();
        }

        private void updateLoop_Tick(object sender, EventArgs e)
        {
            if (lastMsgID == -1)
            {
                listMessages.Items.Clear();
                for(lastMsgID=0;lastMsgID<copyID;lastMsgID++)
                {
                    Message msg = GetMessage(lastMsgID);
                    if (msg != null)
                    {
                        int count = msg.text.Length; ;//90 в строке
                        int sum = (int)Math.Ceiling((double)count / 90);
                        string[] sms = new string[sum];
                        if (sum == 1)
                            sms[0] = msg.text.Substring(0);
                        else
                        {
                            for (int i = 0; i < sum - 1; i++)
                            {
                                sms[i] = msg.text.Substring(90 * i, 90);
                            }
                            sms[sum - 1] = msg.text.Substring(90 * (sum - 1));
                        }
                        listMessages.Items.Add($"|{lastMsgID}|[{msg.username}] {sms[0]}");
                        for (int i = 1; i < sum; i++)
                        {
                            listMessages.Items.Add($"{sms[i]}");
                        }
                    }
                }
                lastMsgID--;
            }
            else
            {
                Message msg = GetMessage(lastMsgID);
                if (msg != null)
                {
                    int count = msg.text.Length; ;//90 в строке
                    int sum = (int)Math.Ceiling((double)count / 90);
                    string[] sms = new string[sum];
                    if (sum == 1)
                        sms[0] = msg.text.Substring(0);
                    else
                    {
                        for (int i = 0; i < sum - 1; i++)
                        {
                            sms[i] = msg.text.Substring(90 * i, 90);
                        }
                        sms[sum - 1] = msg.text.Substring(90 * (sum - 1));
                    }
                    listMessages.Items.Add($"|{lastMsgID}|[{msg.username}] {sms[0]}");
                    for (int i = 1; i < sum; i++)
                    {
                        listMessages.Items.Add($"{sms[i]}");
                    }
                    lastMsgID++;
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e) {
            if (int_token == 0)
      {
        MessageBox.Show("Пожалуйста, пройдите авторизацию или зарегистрируйтесь.","Ошибка при отправлении сообщения", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else 
      { 
            SendMessage(new Message() { 
                username = fieldUsername.Text,
                text = fieldMessage.Text,
            });
      }
         fieldMessage.Text = "";
        }

        // Отправляет сообщение на сервер
        public void SendMessage(Message msg)
        {
            config = IMainFunction.FromJsonFile<Config>("config.json");
            WebRequest req = WebRequest.Create("http://localhost:" + config._Port + "/api/chat");
            //WebRequest req = WebRequest.Create("http://localhost:5000/api/chat");
            req.Method = "POST";
            string postData = JsonConvert.SerializeObject(msg);
            //byte[] bytes = Encoding.UTF8.GetBytes(postData);
            req.ContentType = "application/json";
            //req.ContentLength = bytes.Length;
            StreamWriter reqStream = new StreamWriter(req.GetRequestStream());
            reqStream.Write(postData);
            reqStream.Close();
            req.GetResponse();
        }

        // Получает сообщение с сервера
        Message GetMessage(int id)
        {
            config = IMainFunction.FromJsonFile<Config>("config.json");
            try
            {
                WebRequest req = WebRequest.Create("http://localhost:"+config._Port+$"/api/chat/{id}");
                //WebRequest req = WebRequest.Create($"http://localhost:5000/api/chat/{id}");
                WebResponse resp = req.GetResponse();
                string smsg = new StreamReader(resp.GetResponseStream()).ReadToEnd();

                if (smsg == "Not found") return null;
                return JsonConvert.DeserializeObject<Message>(smsg);
            } catch {
                return null;
            }
        }

    private void btnAuth_Click(object sender, EventArgs e)
    {
        AuthForm = new AuthentificationForm();
        AuthForm.mForm = this;
        AuthForm.Show();
        this.Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            int_token = 0;
            /*AuthForm = new AuthentificationForm();
            RegForm = new RegistartionForm();
            SmileForm = new Smiles();
            PForm = new Port();*/
            TextBox_username = fieldUsername;
            try
            {
                config = IMainFunction.FromJsonFile<Config>("config.json");

            }
            catch
            {
                config = new Config()
                {
                    _Width = 622,//622
                    _Height = 441,//441
                    _Update_rate = 1000,//1000
                    _Port = "5000"//5000
                };
                IMainFunction.ToJsonFile("config.json", config);
            }
            Width = config._Width;
            Height = config._Height;
            updateLoop.Interval = config._Update_rate;
        }
        private void btnReg_Click(object sender, EventArgs e)
{
    RegForm = new RegistartionForm();
    RegForm.mForm = this;
      RegForm.Show();
      this.Visible = false;
    }

        private void listMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox_text = fieldMessage;
            SmileForm = new Smiles();
            SmileForm.mForm = this;
            SmileForm.Show();
            fieldMessage = TextBox_text;
            //this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PForm = new Port();
            PForm.mForm = this;
            PForm.Show();
            this.Visible = false;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (TextBox_username.Text != "Вы не авторизованы")
            {
                Message ms = new Message();
                ms.username = "Объявление";
                ms.text = $"{TextBox_username.Text} вышел из сети.";
                SendMessage(ms);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (TextBox_username.Text == "Вы не авторизованы")
            {
                MessageBox.Show("Для начала Вы должны быть авторизованы.", "Ошибка при получении прав администратора", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                AForm = new Admin();
                AForm.mForm = this;
                AForm.Show();
            }
        }
    }
    [Serializable]
    public class Message
    {
        public string username = "";
        public string text = "";
        public DateTime timestamp;
    }
}
