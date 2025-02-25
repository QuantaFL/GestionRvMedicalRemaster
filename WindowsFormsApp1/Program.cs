using System;
using System.Windows.Forms;
using WindowsFormsApp1.views.Med;
using Serilog;
using WindowsFormsApp1.config;
using static WindowsFormsApp1.config.LogManagement;
using WindowsFormsApp1.views.Admin;
using WindowsFormsApp1.views.Secret;
using WindowsFormsApp1.CustomControls;

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
       

            string elasticSearchUrl = "http://localhost:9200";
            // init des logs seri/ogs
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.Sink(new WhatsAppSink())
                .WriteTo.File(@"C:/Users/UL16/OneDrive/Bureau/Logs/app.log", rollingInterval: RollingInterval.Day)
                //  .WriteTo.Elasticsearch(new ElasticsearchSinkOptions(new Uri(elasticSearchUrl))
                //  {
                //     AutoRegisterTemplate = true,
                //    IndexFormat = "log-{0:yyyy.MM.dd}", 
                //  })
                .CreateLogger();
            Log.Fatal("TEST 123");
            Log.Error("TEST 123");
            Log.Information("Lancement de lapplication...");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmDashAdmin());
            //Application.Run(new frmExecutionReussie("good Morning"));
            Application.Run(new FrmConnexion());

            // vider linstance seri/og
            // Log.CloseAndFlush();
        }
    }
}

  
