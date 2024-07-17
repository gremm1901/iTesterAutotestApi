using System.Text.Json.Serialization;

namespace iTesterAutotestApi.Entities.Requests
{
    public class CodeOperationRequest
    {
        [JsonPropertyName("operationCode")]
        public string OperationCode { get; set; }
    }
}
