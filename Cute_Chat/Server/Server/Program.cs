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
using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Server
{
    public struct Config
    {
        public string _port { get; set; }

        public override string ToString()
        {
            return System.Text.Json.JsonSerializer.Serialize<Config>(this, new JsonSerializerOptions() { WriteIndented = true });
        }
    }
    public class Program
    {
        public static MessagesClass ms;
        public static SessionsClass Sessions;
        public static Config config;

        public static void Main(string[] args)
        {
            try
            {
                config = IMainFunction.FromJsonFile<Config>("config.json");

            }
            catch
            {
                config = new Config()
                {
                    _port= "http://localhost:5000"
                };
            }
                IMainFunction.ToJsonFile("config.json", config);
                ms = new MessagesClass();  //обработка сообщений
                Sessions = new SessionsClass(); // хранение токенов логинов и паролей
                                                //Sessions.addValera();
                Sessions.LoadFromFile();
                ms.LoadFromFile();
            // Console.WriteLine(Sessions.list_tokens.Count);
            CreateHostBuilder(args).Build().Run();
        }

            public static IHostBuilder CreateHostBuilder(string[] args) =>
                Host.CreateDefaultBuilder(args)
                    .ConfigureWebHostDefaults(webBuilder =>
                    {
                        webBuilder
                        .UseStartup<Startup>()
                        .UseUrls(config._port);
                    });


    }
}

