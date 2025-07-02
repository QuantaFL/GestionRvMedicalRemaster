using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace WindowsFormsApp1.ApiConsumer.Requests
{
    public class CreateGroupeSanguinRequest
    {
        [JsonProperty("libelle_groupe_sanguin")]
        [JsonPropertyName("libelle_groupe_sanguin")]
        public string LibelleGroupeSanguin { get; set; }
    }
}
