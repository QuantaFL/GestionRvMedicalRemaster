using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WindowsFormsApp1.ApiConsumer.Models
{
    public class Agenda
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonProperty("medecin_id")]
        [JsonPropertyName("medecin_id")]
        public int MedecinId { get; set; }

            [JsonProperty("data_planifier")]
            [JsonPropertyName("data_planifier")]
            public String DataPlanifier { get; set; }

            [JsonProperty("heure_debut")]
            [JsonPropertyName("heure_debut")]
            public string HeureDebut { get; set; }

            [JsonProperty("heure_fin")]
            [JsonPropertyName("heure_fin")]
            public string HeureFin { get; set; }

            [JsonProperty("lieu")]
            [JsonPropertyName("lieu")]
            public string Lieu { get; set; }

            [JsonProperty("titre")]
            [JsonPropertyName("titre")]
            public string Titre { get; set; }

            [JsonProperty("statut")]
            [JsonPropertyName("statut")]
            public string Statut { get; set; }

            [JsonProperty("creneau")]
            [JsonPropertyName("creneau")]
            public int? Creneau { get; set; }

    [JsonProperty("created_at")]
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}
