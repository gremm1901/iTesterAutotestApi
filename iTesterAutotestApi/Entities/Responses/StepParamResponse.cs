using System.Text.Json.Serialization;

namespace iTesterAutotestApi.Entities.Responses
{
    public class StepParamResponse
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("requirements")]
        public RequirementsResponse Requirements { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("values")]
        public List<string> Values { get; set; }

        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }

        [JsonPropertyName("value")]
        public object Value { get; set; }
    }
}
