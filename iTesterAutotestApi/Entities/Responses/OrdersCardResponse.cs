using System.Text.Json.Serialization;

namespace iTesterAutotestApi.Entities.Responses
{
    public class OrdersCardResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("client")]
        public ClientResponse Client { get; set; }

        [JsonPropertyName("cardProgram")]
        public string CardProgram { get; set; }

        [JsonPropertyName("product")]
        public ProductResponse Product { get; set; }

        [JsonPropertyName("requestId")]
        public int RequestId { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }
    }
}
