﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SuperShop.Web.Data.Entities;
using SuperShop.Web.Helpers;
using SuperShop.Web.Models;
using System.Linq;
using System.Threading.Tasks;

namespace SuperShop.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserHelper _userHelper;

        public AccountController(IUserHelper userHelper)
        {
            _userHelper = userHelper;
        }

        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _userHelper.LoginAsync(model);
                if (result.Succeeded)
                {
                    if (this.Request.Query.Keys.Contains("ReturnUrl"))
                    {
                        return Redirect(this.Request.Query["ReturnUrl"].First());
                    }
                    return this.RedirectToAction("Index", "Home");
                }
            }
            this.ModelState.AddModelError(string.Empty, "Failed  to Login");
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
           await _userHelper.LogoutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult>Register(RegisterNewUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userHelper.GetUserByEmailAsync(model.Username);
                if (user == null)
                {
                    user = new User
                    {
                        FirstName = model.FirtsName,
                        LastName = model.LastName,
                        Email = model.Username,
                        UserName = model.Username
                    };
                    var result = await _userHelper.AddUserAsync(user, model.Password);
                    if(result != IdentityResult.Success)
                    {
                        ModelState.AddModelError(string.Empty, "The user could not be created");
                        return View(model);
                    }
                    var loginViewModel = new LoginViewModel
                    {
                        Password = model.Password,
                        RememberMe = false,
                        UserName = model.Username
                    };
                    var result2 = await _userHelper.LoginAsync(loginViewModel);
                    if (result2.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    ModelState.AddModelError(string.Empty, "The user could not be logged");
 
                }
            }
            return View(model);
        }
    }
}
