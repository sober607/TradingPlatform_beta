using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using TradingPlatformTest.Models;

namespace TradingPlatformTest.Repositories
{
    public class SqlCountriesRepository : ICountriesRepository
    {
        public TradingPlatformContext _context { get; set; }

        public SqlCountriesRepository (TradingPlatformContext context)
        {
            _context = context;
        }

        public List<Country> GetAllCountries()
        {
            var countries = _context.Countries.ToList();

            return countries;
        }

        public Country FindCountryByName(string countryName)
        {
            var country = _context.Countries.FirstOrDefault(t => t.Name.Contains(countryName));

            return country;
        }


    }
}
