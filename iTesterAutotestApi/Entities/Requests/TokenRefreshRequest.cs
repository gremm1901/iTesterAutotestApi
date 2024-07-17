using System.Text.Json.Serialization;

namespace iTesterAutotestApi.Entities.Requests
{
    public class TokenRefreshRequest
    {
        [JsonPropertyName("accessToken")]
        public string AccessToken { get; set; }

        [JsonPropertyName("refreshToken")]
        public string RefreshToken { get; set; }
    }
}
