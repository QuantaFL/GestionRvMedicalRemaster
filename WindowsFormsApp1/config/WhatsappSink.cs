using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Serilog.Core;
using Serilog.Events;

namespace WindowsFormsApp1.config
{
    class LogManagement
    {
        public class WhatsAppSink : ILogEventSink
        {
            public void Emit(LogEvent logEvent)
            {
                if (logEvent.Level == LogEventLevel.Fatal || logEvent.Level == LogEventLevel.Error)
                {
                    SendWhatsAppMessage("Critical error: " + logEvent.MessageTemplate.Text).Wait();
                }
            }
            public  async Task SendWhatsAppMessage(string message)
            {
                using (var client = new HttpClient())
                {
                    var request = new HttpRequestMessage
                    {
                        Method = HttpMethod.Post,
                        RequestUri = new Uri("https://api.wassenger.com/v1/messages"),
                        Headers =
                        {
                            { "Token", "64cb450a45afba46ec8f8b61451b1783cc3a46af21d4fe8a052dacc7395d8ec9e77896e81672aced" },
                        },
                        Content = new StringContent($"{{\"phone\":\"+221782775579\",\"message\":\"{message}\"}}")
                        {
                            Headers =
                            {
                                ContentType = new MediaTypeHeaderValue("application/json")
                            }
                        }
                    };

                    try
                    {
                        using (var response = await client.SendAsync(request))
                        {
                            response.EnsureSuccessStatusCode();
                            var body = await response.Content.ReadAsStringAsync();
                            Console.WriteLine("WhatsApp message sent successfully: " + body);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error sending WhatsApp message: {ex.Message}");
                    }
                }
            }
        }
    }
}
