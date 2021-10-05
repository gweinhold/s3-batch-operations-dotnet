using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using Amazon.Lambda.Core;
using Amazon.Lambda.S3BatchOperationEvents;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace HelloWorld
{
    public class Function
    {
        public async Task<S3BatchObjectResponse> FunctionHandler(S3BatchObjectEvent objectEvent, ILambdaContext context)
        {
            Console.WriteLine(objectEvent.InvocationId);
            Console.WriteLine(objectEvent.InvocationSchemaVersion);
            var s3Task = objectEvent.Tasks.FirstOrDefault();
            Console.WriteLine($"Bucket: {s3Task.S3BucketArn}");
            Console.WriteLine($"S3Key: {s3Task.S3Key}");
            Console.WriteLine($"S3VersionId: {s3Task.S3VersionId}");
            Console.WriteLine($"TaskId: {s3Task.TaskId}");

            // Perform business rules here



            return new S3BatchObjectResponse
            {
                InvocationSchemaVersion = "1.0",
                TreatMissingKeysAs = "PermanentFailure",
                InvocationId = objectEvent.InvocationId,
                Results = new List<Result>()
                {
                    new Result(){ResultCode = "Succeeded", TaskId = s3Task.TaskId, ResultString = "Example Response" }
                }
            };
        }
    }
}
