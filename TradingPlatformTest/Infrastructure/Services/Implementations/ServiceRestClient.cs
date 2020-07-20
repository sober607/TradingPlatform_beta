using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingPlatformTest.Infrastructure.Services.Assistant;
using TradingPlatformTest.Infrastructure.Services.Interfaces;
using Newtonsoft.Json;
using System.Text.Json;

namespace TradingPlatformTest.Infrastructure.Services.Implementations
{
    public class ServiceRestClient : IServiceRestClient
    {
        public CurrencyTempRoot GetCurrencyRate()
        {
            var client = new RestClient("https://openexchangerates.org");
            var request = new RestRequest(@"/api/latest.json?app_id=c994f29999064bc6aed3f63b32032772", Method.GET);
            IRestResponse response = client.Execute(request);

            CurrencyTempRoot currencyRateData = Newtonsoft.Json.JsonConvert.DeserializeObject<CurrencyTempRoot>(response.Content);

            if ((int)response.StatusCode != 200)
            {
                currencyRateData = null;
            }
            Console.WriteLine("REstApiRun");
            return currencyRateData;


        }
    }
}
