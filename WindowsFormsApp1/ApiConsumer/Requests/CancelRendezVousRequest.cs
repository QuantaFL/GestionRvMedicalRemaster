using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace WindowsFormsApp1.ApiConsumer.Requests
{
    public class CancelRendezVousRequest
    {
        [JsonProperty("reason")]
        [JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
