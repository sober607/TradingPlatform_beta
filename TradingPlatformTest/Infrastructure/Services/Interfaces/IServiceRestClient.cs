using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingPlatformTest.Infrastructure.Services.Assistant;

namespace TradingPlatformTest.Infrastructure.Services.Interfaces
{
    public interface IServiceRestClient
    {
        public CurrencyTempRoot GetCurrencyRate();

    }
}
