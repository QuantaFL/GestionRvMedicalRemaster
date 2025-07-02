using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WindowsFormsApp1.ApiConsumer.Models
{
    public class SelectListItem
    {
        [JsonProperty("value")]
        [JsonPropertyName("value")]
        public object Value { get; set; }

        [JsonProperty("text")]
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
