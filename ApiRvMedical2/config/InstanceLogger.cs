using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Serilog;

namespace ApiRvMedical2.config
{
    public class InstanceLogger
    {
      public static ILogger GetInstance()
        {
          return  Log.Logger = new LoggerConfiguration()
            //  .WriteTo.Console()
             // .WriteTo.Sink(new WhatsAppSink())
              .WriteTo.File(@"C:/Logs/app.log/ApiRvMedical2", rollingInterval: RollingInterval.Day)
              // You can also uncomment Elasticsearch integration here if needed
              // .WriteTo.Elasticsearch(new ElasticsearchSinkOptions(new Uri(elasticSearchUrl))
              // {
              //     AutoRegisterTemplate = true,
              //     IndexFormat = "log-{0:yyyy.MM.dd}",
              // })
              .CreateLogger();
           // Log.Information("Lancement de lapplication...");
        }
    }
}