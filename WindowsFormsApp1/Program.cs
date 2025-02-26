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
        static Program()
        {
            string elasticSearchUrl = "http://localhost:9200";

            // Init logs for Serilog
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.Sink(new WhatsAppSink())
                .WriteTo.File(@"C:/Logs/app.log", rollingInterval: RollingInterval.Day)
                // You can also uncomment Elasticsearch integration here if needed
                // .WriteTo.Elasticsearch(new ElasticsearchSinkOptions(new Uri(elasticSearchUrl))
                // {
                //     AutoRegisterTemplate = true,
                //     IndexFormat = "log-{0:yyyy.MM.dd}",
                // })
                .CreateLogger();
                Log.Information("Lancement de lapplication...");
        }
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmConnexion());
            }
            catch
            {
                Log.Fatal("Erreur lors du lancement de l'application");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
    }
}

  
