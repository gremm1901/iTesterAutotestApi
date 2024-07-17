using System.Text.Json.Serialization;

namespace iTesterAutotestApi.Entities.Requests
{
    public class PasswordRequests
    {
        [JsonPropertyName("newPassword")]
        public string NewPassword { get; set; }
    }

}
