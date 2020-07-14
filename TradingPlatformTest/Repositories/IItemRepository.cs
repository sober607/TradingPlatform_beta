using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingPlatformTest.Models;
using TradingPlatformTest.ViewModels;

namespace TradingPlatformTest.Repositories
{
    public interface IItemRepository
    {
        public Task AddItem(ItemAddViewModel item);
    }
}
