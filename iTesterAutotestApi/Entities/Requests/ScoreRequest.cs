using System.Text.Json.Serialization;

namespace iTesterAutotestApi.Entities.Requests
{
    public class ScoreRequest
    {
        [JsonPropertyName("accountId")]
        public int AccountId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
