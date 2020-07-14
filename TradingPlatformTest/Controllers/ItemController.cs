using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
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

        public ItemController (IFileService fileService, IWebHostEnvironment appEnvironment, IItemRepository repository, IUserRepository userRepository)
        {
            _fileService = fileService;
            _appEnvironment = appEnvironment;
            _repository = repository;
            _userRepository = userRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddItem()
        {
            if (User.Identity.Name != null)
            {
                var currency = _userRepository.UserCurrency(User.Identity.Name);
                ViewData["Currency"] = currency;

                return View();
            }
            

            return View();
        }

        [HttpPost]
        public IActionResult AddItem(ItemAddViewModel item)
        {
            var userName = User.Identity.Name;

            if (ModelState.IsValid)
            {
                item.UserName = userName;
                item.Status = Status.Added;
                _repository.AddItem(item);
            }
            

            return View(item);
        }


    }
}