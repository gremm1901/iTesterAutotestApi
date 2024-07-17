using System.Text.Json.Serialization;

namespace iTesterAutotestApi.Entities.Responses
{
    public class RequirementsResponse
    {
        [JsonPropertyName("mask")]
        public object Mask { get; set; }

        [JsonPropertyName("max")]
        public object Max { get; set; }

        [JsonPropertyName("min")]
        public object Min { get; set; }

        [JsonPropertyName("required")]
        public bool Required { get; set; }
    }
}
