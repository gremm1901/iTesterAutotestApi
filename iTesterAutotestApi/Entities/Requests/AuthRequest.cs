using System.Text.Json.Serialization;

namespace iTesterAutotestApi.Entities.Requests
{
    public class AuthRequest
    {
        [JsonPropertyName("login")]
        public string Login { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}