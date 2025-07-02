using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace WindowsFormsApp1.ApiConsumer.Requests
{
    public class UpdateSpecialiteRequest
    {
        [JsonProperty("nom_specialite")]
        [JsonPropertyName("nom_specialite")]
        public string NomSpecialite { get; set; }
    }
}
