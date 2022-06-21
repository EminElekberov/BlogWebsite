using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newless.Controllers
{
    public class NotificationController : Controller
    {
        NotoficationManager nm = new NotoficationManager(new EfNotificationRepository());

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AllNotification()
        {
            var value = nm.GetList();
            return View(value);
        }
    }
}
