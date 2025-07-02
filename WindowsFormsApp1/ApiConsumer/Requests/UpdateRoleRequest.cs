using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace WindowsFormsApp1.ApiConsumer.Requests
{
    public class UpdateRoleRequest
    {
        [JsonProperty("libelle_role")]
        [JsonPropertyName("libelle_role")]
        public string LibelleRole { get; set; }
    }
}
