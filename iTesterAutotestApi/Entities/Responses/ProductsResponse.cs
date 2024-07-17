using System.Text.Json.Serialization;

namespace iTesterAutotestApi.Entities.Responses
{
    public class ProductsResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("shortDescription")]
        public string ShortDescription { get; set; }
    }
}
