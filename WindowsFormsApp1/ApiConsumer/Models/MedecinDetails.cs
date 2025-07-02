using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.ApiConsumer.Models
{
    public class MedecinDetails
    {
        [JsonProperty("id")] // Present when fetched as a full Medecin object
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonProperty("user_id")] // Often present in dedicated Medecin table
        [JsonPropertyName("user_id")]
        public int? UserId { get; set; }

        [JsonProperty("specialite_id")]
        [JsonPropertyName("specialite_id")]
        public int? SpecialiteId { get; set; }

        [JsonProperty("numero_licence")]
        [JsonPropertyName("numero_licence")]
        public string NumeroLicence { get; set; }

        [JsonProperty("user")] // Relation loaded for Medecin objects
        [JsonPropertyName("user")]
        public User User { get; set; }

        [JsonProperty("specialite")] // Relation loaded for Medecin objects
        [JsonPropertyName("specialite")]
        public Specialite Specialite { get; set; }

        [JsonProperty("agendas")] // Relation loaded for Medecin objects
        [JsonPropertyName("agendas")]
        public List<Agenda> Agendas { get; set; }

        // Timestamps that might be present on full Medecin objects
        [JsonProperty("created_at")]
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}
