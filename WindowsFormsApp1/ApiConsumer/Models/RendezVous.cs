using System;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WindowsFormsApp1.ApiConsumer.Models
{
    public class RendezVous
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int Id { get; set; }

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

        [JsonProperty("reason")] // For cancellation
        [JsonPropertyName("reason")]
        public string Reason { get; set; }


        
        [JsonProperty("patient")]
        [JsonPropertyName("patient")]
        public Patient Patient { get; set; }

        [JsonProperty("medecin")] // Contains User and Specialite as per MedecinDetails model
        [JsonPropertyName("medecin")]
        public MedecinDetails Medecin { get; set; }

        [JsonProperty("soin")]
        [JsonPropertyName("soin")]
        public Soin Soin { get; set; }

        [JsonProperty("agenda")]
        [JsonPropertyName("agenda")]
        public Agenda Agenda { get; set; }

        [JsonProperty("created_at")]
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}
