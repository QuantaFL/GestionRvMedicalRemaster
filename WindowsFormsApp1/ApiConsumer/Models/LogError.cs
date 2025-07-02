using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System;

namespace WindowsFormsApp1.ApiConsumer.Models
{
    public class LogError
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonProperty("message")]
        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonProperty("stack_trace")]
        [JsonPropertyName("stack_trace")]
        public string StackTrace { get; set; }

        [JsonProperty("source")]
        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonProperty("level")]
        [JsonPropertyName("level")]
        public string Level { get; set; }

        [JsonProperty("context")]
        [JsonPropertyName("context")]
        public string Context { get; set; }

        [JsonProperty("created_at")]
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        
    }
}
