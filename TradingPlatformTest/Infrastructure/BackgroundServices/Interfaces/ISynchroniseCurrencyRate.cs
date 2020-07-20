using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TradingPlatformTest.Infrastructure.BackgroundServices.Interfaces
{
    public interface ISynchroniseCurrencyRate
    {
        public void UpdateCurrencyRate();

    }
}
