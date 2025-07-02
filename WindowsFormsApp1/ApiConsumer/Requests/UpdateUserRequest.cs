using Newtonsoft.Json;
using System;
using System.Text.Json.Serialization;

namespace WindowsFormsApp1.ApiConsumer.Requests
{
    public class UpdateUserRequest
    {
        [JsonProperty("nom_prenom")]
        [JsonPropertyName("nom_prenom")]
        public string NomPrenom { get; set; }

        [JsonProperty("email")]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonProperty("role_id")]
        [JsonPropertyName("role_id")]
        public int? RoleId { get; set; }

        [JsonProperty("telephone")]
        [JsonPropertyName("telephone")]
        public string Telephone { get; set; }

        [JsonProperty("adresse")]
        [JsonPropertyName("adresse")]
        public string Adresse { get; set; }

        [JsonProperty("date_naissance")]
        [JsonPropertyName("date_naissance")]
        public DateTime? DateNaissance { get; set; }

        [JsonProperty("genre")]
        [JsonPropertyName("genre")]
        public string Genre { get; set; }

        [JsonProperty("photo")]
        [JsonPropertyName("photo")]
        public string Photo { get; set; }

        [JsonProperty("medecin_details")]
        [JsonPropertyName("medecin_details")]
        public MedecinDetailsRequest MedecinDetails { get; set; }

        [JsonProperty("secretaire_details")]
        [JsonPropertyName("secretaire_details")]
        public SecretaireDetailsRequest SecretaireDetails { get; set; }
    }
}
