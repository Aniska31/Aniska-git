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

        public override string ToString()
        {
            return System.Text.Json.JsonSerializer.Serialize<Config>(this, new JsonSerializerOptions() { WriteIndented = true });
        }
    }

    /*public class IMainFunction
    {
        /// <summary>
        /// Преобразует объект в Json
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToJson(object value) =>
            System.Text.Json.JsonSerializer.Serialize(value, new JsonSerializerOptions() { WriteIndented = true });

        /// <summary>
        /// Преобразует из Json в объект <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static T FromJson<T>(string value) =>
            System.Text.Json.JsonSerializer.Deserialize<T>(value, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

        /// <summary>
        /// Преобразует объект в Json и сохраняет в файл
        /// </summary>
        /// <param name="path"></param>
        /// <param name="value"></param>
        public static void ToJsonFile(string path, object value) =>
            File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), path), ToJson(value));

        /// <summary>
        /// Считывает из файла json и преобразует в объект <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <returns></returns>
        public static T FromJsonFile<T>(string path) =>
            FromJson<T>(File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), path)));
    }*/
    public partial class MainForm : Form
    {

        
        // Глобальные переменные
        
        int lastMsgID = 0;
        AuthentificationForm AuthForm;
        RegistartionForm RegForm;
        Smiles SmileForm;
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
            Message msg = GetMessage(lastMsgID);
            if (msg != null) {
                listMessages.Items.Add($"[{msg.username}] {msg.text}");
                lastMsgID++;
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
        void SendMessage(Message msg)
        {
            WebRequest req = WebRequest.Create("http://localhost:5000/api/chat");
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
            try
            {
                WebRequest req = WebRequest.Create($"http://localhost:5000/api/chat/{id}");
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
     
        AuthForm.mForm = this;
        AuthForm.Show();
        this.Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            int_token = 0;
            AuthForm = new AuthentificationForm();
            RegForm = new RegistartionForm();
            SmileForm = new Smiles();
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
                    _Update_rate = 5000//1000
                };
                IMainFunction.ToJsonFile("config.json", config);
            }
            Width = config._Width;
            Height = config._Height;
        }
        private void btnReg_Click(object sender, EventArgs e)
    {
      RegForm.mForm = this;
      RegForm.Show();
      this.Visible = false;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      Message msg = GetMessage(lastMsgID);
      if (msg != null)
      {
        listMessages.Items.Add($"[{msg.username}] {msg.text}");
        lastMsgID++;
      }
    }

        private void listMessages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox_text = fieldMessage;
            SmileForm.mForm = this;
            SmileForm.Show();
            fieldMessage = TextBox_text;
            //this.Visible = false;
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
