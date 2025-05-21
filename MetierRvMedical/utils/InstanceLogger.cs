using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Serilog;
using Serilog.Core;
using Serilog.Formatting.Json;

namespace MetierRvMedical.utils
{
    public static class InstanceLogger
    {
        public static ILogger  GetInstance()
        {
           return Log.Logger = new LoggerConfiguration()
               .WriteTo.File(new JsonFormatter(), @"C:/Logs/app.log.MetierRvMedical", rollingInterval: RollingInterval.Day)
               // You can also uncomment Elasticsearch integration here if needed
               // .WriteTo.Elasticsearch(new ElasticsearchSinkOptions(new Uri(elasticSearchUrl))
               // {
               //     AutoRegisterTemplate = true,
               //     IndexFormat = "log-{0:yyyy.MM.dd}",
               // })
               .CreateLogger();
        }
    }
}