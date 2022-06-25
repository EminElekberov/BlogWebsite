using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Entity.Concencrate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newless.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminMessageController : Controller
    {
        Message2Manager mm = new Message2Manager(new EfMessage2Repository());
        MyContext _myContext = new MyContext();
        public IActionResult Inbox()
        {
            var username = User.Identity.Name;
            var usermail = _myContext.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerId = _myContext.Writers.Where(x => x.Email == usermail).Select(y => y.Id).FirstOrDefault();

            var values = mm.GetInBoxWriter(writerId);
            return View(values);
        }
        public IActionResult SendMessage(Message2 p)
        {
            var username = User.Identity.Name;
            var usermail = _myContext.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerId = _myContext.Writers.Where(x => x.Email == usermail).Select(y => y.Id).FirstOrDefault();
            var valie = mm.GetSendBoxWriter(writerId);
            return View(valie);
        }
        [HttpGet]
        public IActionResult ComposeMessage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ComposeMessage(Message2 message2)
        {
            var username = User.Identity.Name;
            var usermail = _myContext.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerId = _myContext.Writers.Where(x => x.Email == usermail).Select(y => y.Id).FirstOrDefault();
            message2.SenderId = writerId;
            message2.ReceiverId = 2;
            message2.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            message2.Status = true;
            mm.TAdd(message2);
            return RedirectToAction("SendMessage", "AdminMessage");
        }
    }
}
