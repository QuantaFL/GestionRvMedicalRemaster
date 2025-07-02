using Newtonsoft.Json;
using System;
using System.Text.Json.Serialization;

namespace WindowsFormsApp1.ApiConsumer.Requests
{
    public class CreateAgendaRequest
    {
        [JsonProperty("medecin_id")]
        [JsonPropertyName("medecin_id")]
        public int MedecinId { get; set; }

        [JsonProperty("date_agenda")]
        [JsonPropertyName("date_agenda")]
        public DateTime DateAgenda { get; set; }

        [JsonProperty("heure_debut")]
        [JsonPropertyName("heure_debut")]
        public string HeureDebut { get; set; }

        [JsonProperty("heure_fin")]
        [JsonPropertyName("heure_fin")]
        public string HeureFin { get; set; }

        [JsonProperty("disponibilite")]
        [JsonPropertyName("disponibilite")]
        public bool Disponibilite { get; set; }
    }
}
