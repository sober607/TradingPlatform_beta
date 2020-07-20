using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TradingPlatformTest.Infrastructure.BackgroundServices.Interfaces;

namespace TradingPlatformTest.Infrastructure.BackgroundServices.Implementations
{
    public class SyncCurrencyRateBackgroundService : BackgroundService
    {
        private IServiceScopeFactory _scopeFactory { get; }


        public SyncCurrencyRateBackgroundService (IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                using (var scope = _scopeFactory.CreateScope())
                {
                    var context = scope.ServiceProvider.GetService<ISynchroniseCurrencyRate>();

                    context.UpdateCurrencyRate();

                    Console.WriteLine("Sync Done");
                await Task.Delay(TimeSpan.FromMinutes(2));
                
                }
            }
            }
        }


    }

