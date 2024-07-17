using System.Text.Json.Serialization;

namespace iTesterAutotestApi.Entities.Responses
{
    public class ActivateCardResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("client")]
        public ClientResponse Client { get; set; }

        [JsonPropertyName("createdDate")]
        public DateTime CreatedDate { get; set; }

        [JsonPropertyName("currency")]
        public int Currency { get; set; }

        [JsonPropertyName("number")]
        public string Number { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("balance")]
        public int Balance { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }
    }
}
