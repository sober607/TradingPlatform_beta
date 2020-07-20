﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingPlatformTest.Models;
using Microsoft.AspNetCore.Identity;

namespace TradingPlatformTest.Repositories
{
    public class SqlUserRepository : IUserRepository
    {
        public TradingPlatformContext _context { get; set; }

        public SqlUserRepository (TradingPlatformContext context)
        {
            _context = context;
        }

        public string UserCurrency(string username)
        {
            var user = _context.Users.FirstOrDefault(t => t.UserName.Contains(username));
            
            var userCurrencyNameShort = user.Country.Currency.ShortName;

            return userCurrencyNameShort;
        }

        public decimal UserCurrencyRate (string username)
        {
            var user = _context.Users.FirstOrDefault(t => t.UserName == username);

            var userCurrencyNameShort = user.Country.Currency.Rate;

            return userCurrencyNameShort;
        }
    }
}
