using Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using newless.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newless.Controllers
{
    public class RegisterUsersController : Controller
    {

        private readonly UserManager<AppUser> _userManager;

        public RegisterUsersController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserSignUpViewModel p)
        {
            if (ModelState.IsValid)
            {
                var user = new AppUser
                {
                    Email = p.Mail,
                    UserName = p.Username,
                    NameSurname = p.NameSurname
                };
                var result =await _userManager.CreateAsync(user, p.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View();
        }
    }
}
