using Newtonsoft.Json;
using System;
using System.Text.Json.Serialization;

namespace WindowsFormsApp1.ApiConsumer.Requests
{
   public class UpdateSecretaireDetailsRequest
    {
        [JsonProperty("date_embauche")]
        [JsonPropertyName("date_embauche")]
        public DateTime? DateEmbauche { get; set; }

        [JsonProperty("matricule")]
        [JsonPropertyName("matricule")]
        public String matricule { get; set; }
    }
}
