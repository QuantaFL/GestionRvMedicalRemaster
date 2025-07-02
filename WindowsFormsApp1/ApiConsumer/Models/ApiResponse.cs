using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WindowsFormsApp1.ApiConsumer.Models
{
    public class ApiResponse<T>
    {
        [JsonProperty("status")]
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        [JsonPropertyName("data")]
        public T Data { get; set; }

        [JsonProperty("errors")]
        [JsonPropertyName("errors")]
        public object Errors { get; set; }
    }
}
