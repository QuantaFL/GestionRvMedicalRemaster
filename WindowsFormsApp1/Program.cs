using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.views;
using WindowsFormsApp1.views.Admin;
using WindowsFormsApp1.views.Med;
using System;
using System.Windows.Forms;
using Serilog;
using WindowsFormsApp1.views.Secret;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
        //            using System;
        //using System.Windows.Forms;
        //using Serilog;

           // string elasticSearchUrl = "http://localhost:9200";
            // init des logs seri/ogs
         //   Log.Logger = new LoggerConfiguration()
                //.WriteTo.Console()
              //  .WriteTo.File("app.log", rollingInterval: RollingInterval.Day)
           //  .WriteTo.Elasticsearch(new ElasticsearchSinkOptions(new Uri(elasticSearchUrl))
          //  {
           //     AutoRegisterTemplate = true,
            //    IndexFormat = "log-{0:yyyy.MM.dd}", 
          //  })
          //      .CreateLogger();

          //  Log.Information("Lancement de lapplication...");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDashSecretaire());

            // vider linstance seri/og
           // Log.CloseAndFlush();
        }
    }
}

  
