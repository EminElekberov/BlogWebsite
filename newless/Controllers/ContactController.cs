using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Entity.Concencrate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newless.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactRepository());

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact p)
        {
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.Status = true;
            cm.ContactAdd(p);
            return RedirectToAction("Index", "Blog");
        }
    }
}
