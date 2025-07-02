using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System;

namespace WindowsFormsApp1.ApiConsumer.Models
{
    public class Soin
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonProperty("nom_soin")]
        [JsonPropertyName("nom_soin")]
        public string NomSoin { get; set; }

        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonProperty("prix")]
        [JsonPropertyName("prix")]
        public decimal Prix { get; set; }

        [JsonProperty("created_at")]
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}
