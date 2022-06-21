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
    public class NewsLetterController : Controller
    {
        NewsLaterManager nm = new NewsLaterManager(new EfNewsLetter());
        public PartialViewResult SubscribeEmail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SubscribeEmail(NewsLater newsLater)
        {
            newsLater.EmailStatus = true;
            nm.AddNewsLetter(newsLater);
            return PartialView();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
