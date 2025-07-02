using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace WindowsFormsApp1.ApiConsumer.Requests
{
    public class AdminResetPasswordRequest
    {
        [JsonProperty("password")]
        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonProperty("password_confirmation")]
        [JsonPropertyName("password_confirmation")]
        public string PasswordConfirmation { get; set; }
    }
}
