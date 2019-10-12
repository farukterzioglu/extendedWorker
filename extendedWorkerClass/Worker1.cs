using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Worker.App
{
    public class Worker1 : BackgroundService
    {
        private readonly ILogger<Worker1> _logger;

        public Worker1(ILogger<Worker1> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogDebug("Worker1 started...");
            
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker1 running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
