using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace WindowsFormsApp1.ApiConsumer.Requests
{
    public class UpdateMoyenDePaiementRequest
    {
        [JsonProperty("libelle_moyen_paiement")]
        [JsonPropertyName("libelle_moyen_paiement")]
        public string LibelleMoyenPaiement { get; set; }
    }
}
