using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingPlatformTest.Models;
using Microsoft.AspNetCore.Identity;

namespace TradingPlatformTest.Repositories
{
    public interface IUserRepository
    {
        public string UserCurrency(string username);


    }
}
