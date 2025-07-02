using Newtonsoft.Json;
using System;
using System.Text.Json.Serialization;

namespace WindowsFormsApp1.ApiConsumer.Requests
{
    public class CreateRendezVousRequest
    {
        [JsonProperty("patient_id")]
        [JsonPropertyName("patient_id")]
        public int PatientId { get; set; }

        [JsonProperty("medecin_id")]
        [JsonPropertyName("medecin_id")]
        public int MedecinId { get; set; }

        [JsonProperty("agenda_id")]
        [JsonPropertyName("agenda_id")]
        public int AgendaId { get; set; }

        [JsonProperty("soin_id")]
        [JsonPropertyName("soin_id")]
        public int SoinId { get; set; }

        [JsonProperty("date_rendez_vous")]
        [JsonPropertyName("date_rendez_vous")]
        public DateTime DateRendezVous { get; set; }

        [JsonProperty("heure_rendez_vous")]
        [JsonPropertyName("heure_rendez_vous")]
        public string HeureRendezVous { get; set; }

        [JsonProperty("statut")]
        [JsonPropertyName("statut")]
        public string Statut { get; set; }

        [JsonProperty("notes")]
        [JsonPropertyName("notes")]
        public string Notes { get; set; }
    }
}
