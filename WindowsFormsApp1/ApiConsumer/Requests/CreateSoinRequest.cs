using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace WindowsFormsApp1.ApiConsumer.Requests
{
    public class CreateSoinRequest
    {
        [JsonProperty("nom_soin")]
        [JsonPropertyName("nom_soin")]
        public string NomSoin { get; set; }

        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonProperty("prix")]
        [JsonPropertyName("prix")]
        public decimal Prix { get; set; }
    }
}
