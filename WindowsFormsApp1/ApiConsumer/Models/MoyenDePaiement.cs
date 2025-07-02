using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System;

namespace WindowsFormsApp1.ApiConsumer.Models
{
    public class MoyenDePaiement
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonProperty("libelle_moyen_paiement")]
        [JsonPropertyName("libelle_moyen_paiement")]
        public string LibelleMoyenPaiement { get; set; }

        [JsonProperty("created_at")]
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}
