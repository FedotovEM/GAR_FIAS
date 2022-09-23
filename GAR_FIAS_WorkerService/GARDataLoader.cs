using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GAR_FIAS_WorkerService
{
    public class GARDataLoader : BackgroundService
    {
        private readonly ILogger<GARDataLoader> _logger;

        public GARDataLoader(ILogger<GARDataLoader> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                WorkWithData.Insert();
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
