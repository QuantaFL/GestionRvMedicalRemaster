using System;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WindowsFormsApp1.ApiConsumer.Models
{
    public class User
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int Id { get; set; }

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

        [JsonProperty("statut")]
        [JsonPropertyName("statut")]
        public bool? Statut { get; set; }

        [JsonProperty("photo")]
        [JsonPropertyName("photo")]
        public string Photo { get; set; }

        [JsonProperty("role")]
        [JsonPropertyName("role")]
        public Role Role { get; set; }

        [JsonProperty("medecin_details")]
        [JsonPropertyName("medecin_details")]
        public MedecinDetails MedecinDetails { get; set; }

        [JsonProperty("secretaire_details")]
        [JsonPropertyName("secretaire_details")]
        public SecretaireDetails SecretaireDetails { get; set; }

        [JsonProperty("email_verified_at")]
        [JsonPropertyName("email_verified_at")]
        public DateTime? EmailVerifiedAt { get; set; }

        [JsonProperty("created_at")]
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}
