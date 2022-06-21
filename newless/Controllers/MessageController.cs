using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newless.Controllers
{
    public class MessageController : Controller
    {
        Message2Manager message2Manager = new Message2Manager(new EfMessage2Repository());

        public IActionResult InBox()
        {
            int id = 6;
            var values = message2Manager.getListWriter(id);
            return View(values);
        }
        public IActionResult MessageDetails(int id)
        {
            var values = message2Manager.GetById(id);
            return View(values);
        }
    }
}
