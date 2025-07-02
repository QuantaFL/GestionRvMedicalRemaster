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

        [JsonProperty("medecin")] // Relation: medecin.user, medecin.specialite
        [JsonPropertyName("medecin")]
        public MedecinDetails Medecin { get; set; } // MedecinDetails includes User and Specialite

        [JsonProperty("rendez_vous")] // Relation from GET /api/agendas/{agenda}
        [JsonPropertyName("rendez_vous")]
        public List<RendezVous> RendezVous { get; set; } // Assuming one agenda slot can have multiple (unlikely) or this is for a different context. More likely a single RendezVous if booked.
                                                        // Or this is a list of RendezVous linked to this medecin on this day through various agenda slots.
                                                        // For now, List<RendezVous> is flexible.
                                                        // The API doc for GET /api/agendas/{agenda} says "rendezVous" (plural).

        [JsonProperty("created_at")]
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}
