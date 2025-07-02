using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace WindowsFormsApp1.ApiConsumer.Models
{
    
    public class LoginResponseData
    {
        [JsonProperty("token")]
        [JsonPropertyName("token")]
        public string Token { get; set; }

        [JsonProperty("user")] // Assuming user details are returned on login
        [JsonPropertyName("user")]
        public User User { get; set; }

        // Or, if the API returns the token in a different structure, adjust this.
        // For example, some APIs might return the token directly, not nested in "data".
        // The ApiResponse<LoginResponseData> will be used by the service.
        // If token is in header and user data is in body, service needs more specific handling.
        // For Sanctum, token might be cookie-based for web, or issued for API tokens.
        // This model assumes an API token is explicitly returned in the JSON response body.
    }
}
