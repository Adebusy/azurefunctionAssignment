using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;

namespace day20azurefunction
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static void Run([QueueTrigger("input", Connection = "queuecon")]string myQueueItem, TraceWriter log)
        {
            log.Info($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
