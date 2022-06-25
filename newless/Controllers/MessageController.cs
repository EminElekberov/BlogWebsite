using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Entity.Concencrate;
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
        MyContext _myContext = new MyContext();

        public IActionResult InBox()
        {

            var username = User.Identity.Name;
            var usermail = _myContext.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerId = _myContext.Writers.Where(x => x.Email == usermail).Select(y => y.Id).FirstOrDefault();

            var values = message2Manager.getListWriter(writerId);
            return View(values);
        }
        public IActionResult MessageDetails(int id)
        {
            var values = message2Manager.GetById(id);
            return View(values);
        }
        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(Message2 p)
        {
            var username = User.Identity.Name;
            var usermail = _myContext.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerId = _myContext.Writers.Where(x => x.Email == usermail).Select(y => y.Id).FirstOrDefault();
            p.SenderId = writerId;
            p.ReceiverId = 3;
            p.Status = true;
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            message2Manager.TAdd(p);
            return RedirectToAction("InBox");
        }
    }
}
