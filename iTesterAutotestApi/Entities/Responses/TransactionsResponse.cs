using System.Text.Json.Serialization;

namespace iTesterAutotestApi.Entities.Responses
{
    public class TransactionsResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("account")]
        public AccountResponse Account { get; set; }

        [JsonPropertyName("receiver")]
        public string Receiver { get; set; }

        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        [JsonPropertyName("paymentDate")]
        public DateTime PaymentDate { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("comment")]
        public string Comment { get; set; }

        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
