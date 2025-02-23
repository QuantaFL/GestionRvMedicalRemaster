using System;
using System.Windows.Forms;
using WindowsFormsApp1.views.Med;
using Serilog;

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


            // string elasticSearchUrl = "http://localhost:9200";
            // init des logs seri/ogs
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File(@"C:\Users\cheikh\Documents\app.log", rollingInterval: RollingInterval.Day)
                //  .WriteTo.Elasticsearch(new ElasticsearchSinkOptions(new Uri(elasticSearchUrl))
                //  {
                //     AutoRegisterTemplate = true,
                //    IndexFormat = "log-{0:yyyy.MM.dd}", 
                //  })
                .CreateLogger();

            Log.Information("Lancement de lapplication...");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmDashAdmin());
            Application.Run(new frmMedAgenda());

            // vider linstance seri/og
            Log.CloseAndFlush();
        }
    }
}

  
