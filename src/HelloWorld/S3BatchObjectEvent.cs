using System.Collections.Generic;

namespace Amazon.Lambda.S3BatchOperationEvents
{
    public class Job
    {
        public string Id { get; set; }
    }

    public class Task
    {
        public string TaskId { get; set; }
        public string S3Key { get; set; }
        public string S3VersionId { get; set; }
        public string S3BucketArn { get; set; }
    }

    public class S3BatchObjectEvent
    {
        public string InvocationSchemaVersion { get; set; }
        public string InvocationId { get; set; }
        public Job Job { get; set; }
        public IList<Task> Tasks { get; set; }
    }
}


