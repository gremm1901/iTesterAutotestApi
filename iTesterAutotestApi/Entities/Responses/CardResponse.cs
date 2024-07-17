using System.Text.Json.Serialization;

namespace iTesterAutotestApi.Entities.Responses
{
    public class CardResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("account")]
        public AccountResponse Account { get; set; }

        [JsonPropertyName("client")]
        public ClientResponse Client { get; set; }

        [JsonPropertyName("cardProgram")]
        public string CardProgram { get; set; }

        [JsonPropertyName("product")]
        public ProductResponse Product { get; set; }

        [JsonPropertyName("number")]
        public string Number { get; set; }

        [JsonPropertyName("month")]
        public string Month { get; set; }

        [JsonPropertyName("year")]
        public string Year { get; set; }

        [JsonPropertyName("pinRequired")]
        public bool PinRequired { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }
    }
}
