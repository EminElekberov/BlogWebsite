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
    public class WriterAboutOnDashboard:ViewComponent
    {
        WriterManager writerManager = new WriterManager(new EfWriterRepository());
        MyContext myContext = new MyContext();
        public IViewComponentResult Invoke()
        {
            var userMail = User.Identity.Name;
            var writerId = myContext.Writers.Where(x => x.Email == userMail).Select(x => x.Id).FirstOrDefault();
            var value = writerManager.GetWriterById(writerId);
            return View(value);
        }
    }
}
