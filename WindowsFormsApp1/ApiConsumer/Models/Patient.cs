using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WindowsFormsApp1.ApiConsumer.Models
{
    public class Patient
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonProperty("nom_prenom")]
        [JsonPropertyName("nom_prenom")]
        public string NomPrenom { get; set; }

        [JsonProperty("date_naissance")]
        [JsonPropertyName("date_naissance")]
        public DateTime DateNaissance { get; set; }

        [JsonProperty("genre")]
        [JsonPropertyName("genre")]
        public string Genre { get; set; }

        [JsonProperty("adresse")]
        [JsonPropertyName("adresse")]
        public string Adresse { get; set; }

        [JsonProperty("telephone")]
        [JsonPropertyName("telephone")]
        public string Telephone { get; set; }

        [JsonProperty("email")]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonProperty("groupe_sanguin_id")]
        [JsonPropertyName("groupe_sanguin_id")]
        public int? GroupeSanguinId { get; set; }

        [JsonProperty("groupe_sanguin")] // Potential relation if API sends it
        [JsonPropertyName("groupe_sanguin")]
        public GroupeSanguin GroupeSanguin { get; set; }

        [JsonProperty("rendez_vous")] // Relation from GET /api/patients/{patient}
        [JsonPropertyName("rendez_vous")]
        public List<RendezVous> RendezVous { get; set; }

        [JsonProperty("created_at")]
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}
