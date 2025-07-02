using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System;

namespace WindowsFormsApp1.ApiConsumer.Models
{
    public class SecretaireDetails
    {
        [JsonProperty("id")] // Present when fetched as a full Secretaire object
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonProperty("user_id")] // Often present in dedicated Secretaire table
        [JsonPropertyName("user_id")]
        public int? UserId { get; set; }

        [JsonProperty("date_embauche")]
        [JsonPropertyName("date_embauche")]
        public DateTime? DateEmbauche { get; set; }

        [JsonProperty("user")] // Relation loaded for Secretaire objects
        [JsonPropertyName("user")]
        public User User { get; set; }

        // Timestamps that might be present on full Secretaire objects
        [JsonProperty("created_at")]
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}
