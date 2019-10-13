using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Company.Application1
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly Settings _settings;

        public Worker(ILogger<Worker> logger, Settings settings)
        {
            _logger = logger;
            _settings = settings;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
             _logger.LogInformation($"{nameof(Worker)} started.");

            try
            {
                await DoWork(stoppingToken);
            }
            catch (TaskCanceledException) { }
            catch (System.Exception ex)
            {
                _logger.LogCritical(ex.ToString());
                await this.StopAsync(stoppingToken);
            }
        }

        private async Task DoWork(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker is running at: {time}", DateTimeOffset.Now);
                await Task.Delay(TimeSpan.FromSeconds(_settings.WorkerIntervalSec), stoppingToken);
            }
        }

        public override async Task StopAsync(CancellationToken cancellationToken)
		{
            _logger.LogInformation($"{nameof(Worker)} stopped.");
            await base.StopAsync(cancellationToken);
        }
    }
}
