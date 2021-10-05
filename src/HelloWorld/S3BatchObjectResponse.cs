using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Amazon.Lambda.S3BatchOperationEvents
{
    public class Result
    {
        [JsonPropertyName("taskId")]
        public string TaskId { get; set; }

        [JsonPropertyName("resultCode")]
        public string ResultCode { get; set; }

        [JsonPropertyName("resultString")]
        public string ResultString { get; set; }
    }

    public class S3BatchObjectResponse
    {
        [JsonPropertyName("invocationSchemaVersion")]
        public string InvocationSchemaVersion { get; set; }

        [JsonPropertyName("treatMissingKeysAs")]
        public string TreatMissingKeysAs { get; set; }

        [JsonPropertyName("invocationId")]
        public string InvocationId { get; set; }

        [JsonPropertyName("results")]
        public IList<Result> Results { get; set; }
    }
}


