using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newless.ViewComponents.Writer
{
    public class WriterMessageNotification: ViewComponent
    {
        Message2Manager message2Manager = new Message2Manager(new EfMessage2Repository());
        MyContext mycontext = new MyContext();

        public IViewComponentResult Invoke()
        {
            var username = User.Identity.Name;
            var useremail = mycontext.Users.Where(x => x.UserName == username).Select(x => x.Email).FirstOrDefault();
            var writerId = mycontext.Writers.Where(x => x.Email == useremail).Select(x => x.Id).FirstOrDefault();

           // int id = 6;
            var values = message2Manager.getListWriter(writerId);
            return View(values);
        }
    }
}
