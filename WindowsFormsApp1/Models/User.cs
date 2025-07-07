// ...existing using directives...
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace WindowsFormsApp1.Models
{
    public class User
    {
        // ...autres propriétés existantes...

        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonProperty("nom_prenom")]
        [JsonPropertyName("nom_prenom")]
        public string NomPrenom { get; set; } 

        [JsonProperty("addresse")]
        [JsonPropertyName("addresse")]
        public string Addresse { get; set; }  // addresse

        [JsonProperty("email")]
        [JsonPropertyName("email")]
        public string Email { get; set; }     // email

        [JsonProperty("tel")]
        [JsonPropertyName("tel")]
        public string Tel { get; set; }       // tel

        [JsonProperty("date_naissance")]
        [JsonPropertyName("date_naissance")]
        public string DateNaissance { get; set; } // date_naissance

        [JsonProperty("identifiant")]
        [JsonPropertyName("identifiant")]
        public string Identifiant { get; set; }     // identifiant

        [JsonProperty("password")]
        [JsonPropertyName("password")]
        public string Password { get; set; }        // password (hashé)

        [JsonProperty("status")]
        [JsonPropertyName("status")]
        public string Status { get; set; }          // status (ex: "actif")

        [JsonProperty("role_id")]
        [JsonPropertyName("role_id")]
        public int RoleId { get; set; }             // role_id

        [JsonProperty("premiere_connexion")]
        [JsonPropertyName("premiere_connexion")]
        public bool PremiereConnexion { get; set; } // premiere_connexion

        // Navigation property for Role (si nécessaire)
        [JsonProperty("role")]
        [JsonPropertyName("role")]
        public virtual Role Role { get; set; }

        // ...autres propriétés ou méthodes...
    }
}