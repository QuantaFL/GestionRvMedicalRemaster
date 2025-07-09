using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace WindowsFormsApp1.ApiConsumer.Requests
{
    public class UpdateMedecinDetailsRequest
    {
        [JsonProperty("numero_ordre")]
        [JsonPropertyName("numero_ordre")]
        public string NumeroLicence { get; set; }

        [JsonProperty("specialite_id")]
        [JsonPropertyName("specialite_id")]
        public int? SpecialiteId { get; set; }
    }
}
