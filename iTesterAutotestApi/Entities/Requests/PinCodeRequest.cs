using System.Text.Json.Serialization;

namespace iTesterAutotestApi.Entities.Requests
{
    public class PinCodeRequest
    {
        [JsonPropertyName("pinCode")]
        public int PinCode { get; set; }
    }

}
