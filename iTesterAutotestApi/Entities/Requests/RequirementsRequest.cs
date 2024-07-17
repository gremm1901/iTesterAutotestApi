using System.Text.Json.Serialization;

public class RequirementsRequest
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
