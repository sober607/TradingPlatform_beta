using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingPlatformTest.Infrastructure;
using TradingPlatformTest.Models;
using TradingPlatformTest.ViewModels;

namespace TradingPlatformTest.Repositories
{
    public class SqlItemRepository : IItemRepository
    {
        public IFileService _fileService { get; set; }

        public TradingPlatformContext _context { get; set; }

        public SqlItemRepository (IFileService fileService, TradingPlatformContext context)
        {
            _fileService = fileService;
            _context = context;
        }

        public async Task AddItem(ItemAddViewModel item)
        {
            User user = _context.Users.FirstOrDefault(t => t.UserName == item.UserName);
            
            Item newItem = new Item() {
                Name = item.Name,
                Description = item.Description,
                ImgUrl = await _fileService.UploadImageAsync(item.File),
                Price = item.Price,
                User = (user != null) ? user : null,
                IsService = item.IsService,
                IsMultiCountryPossible = item.IsMultiCountryPossible
            };

            _context.Items.Add(newItem);
            _context.SaveChanges();

        }
    }
}
