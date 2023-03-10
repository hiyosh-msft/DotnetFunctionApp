using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace DotnetFunctionApp
{
    public class Function1
    {
        [FunctionName("Function1")]
        public void Run([TimerTrigger("0 */5 * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
            log.LogInformation("Git push 3");
        }
    }
}
