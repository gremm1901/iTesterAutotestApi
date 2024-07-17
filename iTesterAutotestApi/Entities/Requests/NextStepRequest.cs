using System.Text.Json.Serialization;

public class NextStepRequest
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("requirements")]
    public RequirementsRequest Requirements { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("values")]
    public List<string> Values { get; set; }

    [JsonPropertyName("identifier")]
    public string Identifier { get; set; }

    [JsonPropertyName("value")]
    public string Value { get; set; }
}
