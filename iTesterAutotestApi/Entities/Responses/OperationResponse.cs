﻿using System.Text.Json.Serialization;

namespace iTesterAutotestApi.Entities.Responses
{
    public class OperationResponse
    {
        [JsonPropertyName("clientId")]
        public int ClientId { get; set; }

        [JsonPropertyName("isConfirmed")]
        public bool IsConfirmed { get; set; }

        [JsonPropertyName("isFinished")]
        public bool IsFinished { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("operationCode")]
        public string OperationCode { get; set; }

        [JsonPropertyName("requestId")]
        public int RequestId { get; set; }

        [JsonPropertyName("startDate")]
        public DateTime StartDate { get; set; }

        [JsonPropertyName("stepId")]
        public int StepId { get; set; }

        [JsonPropertyName("stepParams")]
        public List<StepParamResponse> StepParams { get; set; }
    }
}