using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System; // For DateTime

namespace WindowsFormsApp1.ApiConsumer.Models
{
    public class Role
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonProperty("libelle_role")]
        [JsonPropertyName("libelle_role")]
        public string LibelleRole { get; set; }

        // Timestamps that might be present on full Role objects from /api/roles endpoint
        [JsonProperty("created_at")]
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}
