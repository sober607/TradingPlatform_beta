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

        private TradingPlatformContext _context { get; set; }

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
                Category = _context.Categories.FirstOrDefault( t => t.Id == item.CategoryId),
                IsMultiCountryPossible = item.IsMultiCountryPossible
            };

            _context.Items.Add(newItem);
            _context.SaveChanges();

        }

        public IEnumerable<Item> GetCategorisedItems(int categoryId)
        {
            var itemsList = _context.Items.Where(t => t.CategoryId == categoryId).ToList();

            return itemsList;
        }

        public Item GetItem(int itemId)
        {
            var item = _context.Items.FirstOrDefault(t=> t.Id == itemId);

            return item;
        }
    }
}
