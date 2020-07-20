using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TradingPlatformTest.Infrastructure;
using TradingPlatformTest.Models;
using TradingPlatformTest.Repositories;
using TradingPlatformTest.ViewModels;

namespace TradingPlatformTest.Controllers
{
    public class ItemController : Controller
    {
        public IFileService _fileService { get; set; }

        public IWebHostEnvironment _appEnvironment { get; set; }

        public IItemRepository _repository { get; set; }

        public IUserRepository _userRepository { get; set; }

        public ICategoryRepository _categoryRepository { get; set; }

        public ItemController (IFileService fileService, IWebHostEnvironment appEnvironment, IItemRepository repository, IUserRepository userRepository, ICategoryRepository categoryRepository)
        {
            _fileService = fileService;
            _appEnvironment = appEnvironment;
            _repository = repository;
            _userRepository = userRepository;
            _categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        [HttpGet]
        public IActionResult AddItem()
        {
            if (User.Identity.Name != null)
            {
                var currency = _userRepository.UserCurrency(User.Identity.Name);
                ViewData["Currency"] = currency;
                ItemAddViewModel model = new ItemAddViewModel();
                model.Categories = _categoryRepository.GetAllCategoriesSelectedList();


                return View(model);
            }
            

            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddItem(ItemAddViewModel item)
        {
            var userName = User.Identity.Name;

            if (ModelState.IsValid)
            {
                item.UserName = userName;
                item.Status = Status.Added;
                
                await _repository.AddItem(item);
            }
            

            return View(item);
        }

        public IActionResult ViewItem (int itemId)
        {
            var item = _repository.GetItem(itemId);
            
            ItemViewModel model = null;


            if (item != null)
            {
                var buyerCurrency = _userRepository.UserCurrency(User.Identity.Name);
                var buyerCurrencyRate = _userRepository.UserCurrencyRate(User.Identity.Name);
                var sellerCurrency = _userRepository.UserCurrency(item.User.Name);
                string imgUrl = @"/images/no-image.png";

                if (item.ImgUrl != null)
                { imgUrl = item.ImgUrl; }

                if (buyerCurrency == sellerCurrency || buyerCurrency == null)
                {
                    model = new ItemViewModel()
                    {
                        ItemId = itemId,
                        ItemName = item.Name,
                        ItemDescription = item.Description,
                        SellerPrice = item.Price,
                        SellerCurrency = item.User.Country.Currency.ShortName,
                        ImgUrl = imgUrl
                    };
                }
                else
                {
                    model = new ItemViewModel()
                    {
                        ItemId = itemId,
                        ItemName = item.Name,
                        ItemDescription = item.Description,
                        SellerPrice = item.Price,
                        SellerCurrency = item.User.Country.Currency.ShortName,
                        
                        BuyerCurrency = buyerCurrency,
                        BuyerPrice = item.Price * item.User.Country.Currency.Rate / buyerCurrencyRate,
                        ImgUrl = imgUrl
                    };

                }
            }
            else
            {
                ViewBag.nullItem = "No item with such id";
                return View();
            }

            return View(model);
        }

        [Authorize]
        public IActionResult Buy(int itemId)
        {


            return View();
        }


    }
}