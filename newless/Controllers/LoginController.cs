using DataAccessLayer.Concrete;
using Entity.Concencrate;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace newless.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Writer p)
        {

            MyContext myContext = new MyContext();
            var datavalue = myContext.Writers.FirstOrDefault(x => x.Email == p.Email && x.Password == p.Password);
            if (datavalue!=null)
            {
                var claims= new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.Email)
                };
                var userIdentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index","Dashboard");
            }
            //if (datavalue!=null)
            //{
            //    HttpContext.Session.SetString("username", p.Email);
            //    return RedirectToAction("index", "blog");
            //}
            else
            {
                return View();
            }
        }
    }
}
