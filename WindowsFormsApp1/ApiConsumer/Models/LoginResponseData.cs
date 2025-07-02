using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace WindowsFormsApp1.ApiConsumer.Models
{
    
    public class LoginResponseData
    {

        [JsonProperty("user")]
        [JsonPropertyName("user")]
        public User User { get; set; }
}
}
