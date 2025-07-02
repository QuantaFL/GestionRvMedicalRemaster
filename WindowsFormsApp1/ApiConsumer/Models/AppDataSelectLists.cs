using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WindowsFormsApp1.ApiConsumer.Models
{
    public class AppDataSelectLists
    {
        [JsonProperty("roles")]
        [JsonPropertyName("roles")]
        public List<SelectListItem> Roles { get; set; }

        [JsonProperty("specialites")]
        [JsonPropertyName("specialites")]
        public List<SelectListItem> Specialites { get; set; }

        
    }
}
