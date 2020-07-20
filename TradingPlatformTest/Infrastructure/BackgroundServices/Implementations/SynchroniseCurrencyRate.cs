using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingPlatformTest.Infrastructure.BackgroundServices.Interfaces;
using TradingPlatformTest.Infrastructure.Services.Interfaces;
using TradingPlatformTest.Models;

namespace TradingPlatformTest.Infrastructure.BackgroundServices.Implementations
{
    public class SynchroniseCurrencyRate : ISynchroniseCurrencyRate
    {
        private IServiceRestClient _restClient { get; set; }

        private TradingPlatformContext _context { get; set; }

        public SynchroniseCurrencyRate(IServiceRestClient restClient, TradingPlatformContext context)
        {
            _restClient = restClient;
            _context = context;
        }

        public void UpdateCurrencyRate()
        {
            var currencyRateRemoteServerData = _restClient.GetCurrencyRate();

            if (currencyRateRemoteServerData != null)
            {
                foreach (var t in _context.Currencies.ToList())
                {
                    var currencyShortNameFromLocalDatabase = t.ShortName;

                    t.Rate = currencyRateRemoteServerData.Rates.FirstOrDefault(t => t.Key.ToUpper().Contains(currencyShortNameFromLocalDatabase.ToUpper())).Value;

                    System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
                    dtDateTime = dtDateTime.AddSeconds(currencyRateRemoteServerData.TimeStamp).ToLocalTime();
                    t.RateLastSyncTime = dtDateTime.ToString();
                    
                }

                _context.SaveChanges();
            }

        }
    }
}
