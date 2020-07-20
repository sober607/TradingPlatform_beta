using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingPlatformTest.Models;
using TradingPlatformTest.Repositories;
using TradingPlatformTest.ViewModel;

namespace TradingPlatformTest.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<User> _signInManager;

        private readonly UserManager<User> _userManager;

        public ICountriesRepository _countriesRepository { get; set; }

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, ICountriesRepository countriesRepository)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _countriesRepository = countriesRepository;
        }

        [HttpGet]
        public IActionResult Register()
        {
            var model = new RegisterViewModel();
            var countries =  _countriesRepository.GetAllCountries();
            int i = 0;
            model.Countires = new List<SelectListItem>();

            foreach (var t in countries)
            {
                model.Countires.Add(new SelectListItem() { Text = t.Name, Value = t.Name} );
                i++;
            }

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            
            if (ModelState.IsValid)
            {
                var user = new User() { UserName = model.Email, Email = model.Email, Name = model.Name, Country = _countriesRepository.FindCountryByName(model.CountryName) };
                var createTask = await _userManager.CreateAsync(user, model.Password);

                if (createTask.Succeeded)
                {
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var t in createTask.Errors)
                    {
                        ModelState.AddModelError("", t.Description);
                    }
                }
                return View(model);
            }
            else
            {
                var model1 = new RegisterViewModel();
                var countries = _countriesRepository.GetAllCountries();
                int i = 0;
                model1.Countires = new List<SelectListItem>();

                foreach (var t in countries)
                {
                    model1.Countires.Add(new SelectListItem() { Text = t.Name, Value = t.Name });
                    i++;
                }

                return View(model1);
            }

            
        }


        [HttpGet]
        public IActionResult Login(string ReturnUrl = null)
        {
            return View(new LoginViewModel { ReturnUrl = ReturnUrl });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var resultSignIn = await _signInManager.PasswordSignInAsync(model.Email, model.Password, true, false);
                if (resultSignIn.Succeeded)
                {
                    if (!string.IsNullOrEmpty(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Home", "Index");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Sign in failed. Wrong login or password");
                }
            }

            return View(model);
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
