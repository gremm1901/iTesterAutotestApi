using System.Text.Json.Serialization;

namespace iTesterAutotestApi.Entities.Requests
{
    public class LoginRequest
    {
        [JsonPropertyName("login")]
        public string Login { get; set; }
    }
}
