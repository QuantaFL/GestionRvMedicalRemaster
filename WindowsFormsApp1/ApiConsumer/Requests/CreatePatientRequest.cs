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

        /*

                   [JsonProperty("genre")]
         [JsonPropertyName("genre")]
         public string Genre { get; set; }
         */


        [JsonProperty("taille")]
        [JsonPropertyName("taille")]
        public float? taille { get; set; }


        [JsonProperty("poids")]
        [JsonPropertyName("poids")]
        public float? poids { get; set; }

        [JsonProperty("addresse")]
        [JsonPropertyName("addresse")]
        public string Adresse { get; set; }

        [JsonProperty("tel")]
        [JsonPropertyName("tel")]
        public string Telephone { get; set; }

        [JsonProperty("email")]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonProperty("groupe_sanguin_id")]
        [JsonPropertyName("groupe_sanguin_id")]
        public int? GroupeSanguinId { get; set; }
    }
}
