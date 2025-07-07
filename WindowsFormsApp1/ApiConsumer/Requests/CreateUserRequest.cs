using Newtonsoft.Json;
using System;
using System.Text.Json.Serialization;

namespace WindowsFormsApp1.ApiConsumer.Requests
{
    public class CreateUserRequest
    {
        [JsonProperty("nom_prenom")]
        [JsonPropertyName("nom_prenom")]
        public string NomPrenom { get; set; }

        [JsonProperty("email")]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonProperty("password_confirmation")]
        [JsonPropertyName("password_confirmation")]
        public string PasswordConfirmation { get; set; }

        [JsonProperty("role_id")]
        [JsonPropertyName("role_id")]
        public int RoleId { get; set; }

        [JsonProperty("tel")]
        [JsonPropertyName("tel")]
        public string Tel { get; set; }

        [JsonProperty("addresse")]
        [JsonPropertyName("addresse")]
        public string Addresse { get; set; }

        [JsonProperty("date_naissance")]
        [JsonPropertyName("date_naissance")]
        public string DateNaissance { get; set; } // Format as "yyyy-MM-dd"

        [JsonProperty("identifiant")]
        [JsonPropertyName("identifiant")]
        public string Identifiant { get; set; }

        [JsonProperty("status")]
        [JsonPropertyName("status")]
        public bool? Status { get; set; }

        [JsonProperty("premiere_connexion")]
        [JsonPropertyName("premiere_connexion")]
        public int? PremiereConnexion { get; set; }

        [JsonProperty("medecin_details")]
        [JsonPropertyName("medecin_details")]
        public MedecinDetailsRequest MedecinDetails { get; set; }

        [JsonProperty("secretaire_details")]
        [JsonPropertyName("secretaire_details")]
        public SecretaireDetailsRequest SecretaireDetails { get; set; }
    }

    public class MedecinDetailsRequest
    {
        [JsonProperty("specialite_id")]
        [JsonPropertyName("specialite_id")]
        public int? SpecialiteId { get; set; }

        [JsonProperty("numero_ordre")]
        [JsonPropertyName("numero_ordre")]
        public string NumeroOrdre { get; set; }
    }

    public class SecretaireDetailsRequest
    {
        [JsonProperty("telephone_fixe")]
        [JsonPropertyName("telephone_fixe")]
        public string TelephoneFixe { get; set; }

        [JsonProperty("matricule")]
        [JsonPropertyName("matricule")]
        public string Matricule { get; set; }


    }
}