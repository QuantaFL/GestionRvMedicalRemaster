using Newtonsoft.Json;
using System;
using System.Text.Json.Serialization;

namespace WindowsFormsApp1.ApiConsumer.Requests
{
    public class CreatePatientRequest
    {
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
    }
}
