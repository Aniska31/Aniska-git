using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;


namespace Server
{

    public class Startup
    {
        public static Config config;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


    public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            try
            {
                config = IMainFunction.FromJsonFile<Config>("config.json");

            }
            catch
            {
                config = new Config()
                {
                    _port = "http://localhost:5000"
                };
            }
            services.AddControllers();
            services.AddCors(options =>
            {
                options.AddPolicy("CorsApi",
                builder => builder.WithOrigins(config._port)
                .AllowAnyHeader()
                .AllowAnyMethod());
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, Microsoft.AspNetCore.Hosting.IApplicationLifetime applicationLifetime,
                      ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseAuthorization();
            applicationLifetime.ApplicationStarted.Register(OnApplicationStarted);
            applicationLifetime.ApplicationStopping.Register(OnApplicationStopping);
            applicationLifetime.ApplicationStopped.Register(OnApplicationStopped);


      app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
      protected void OnApplicationStarted()
      {

      }

      protected void OnApplicationStopping()
      {
        Program.Sessions.SaveToFile();
        Program.ms.SaveToFile();
        }

      protected void OnApplicationStopped()
      {
       
      }

  }
}
