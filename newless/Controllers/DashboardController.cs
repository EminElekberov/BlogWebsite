using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newless.Controllers
{
    public class DashboardController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            MyContext myContext = new MyContext();
            var username = User.Identity.Name;
            var useremail = myContext.Users.Where(x => x.UserName == username).Select(x => x.Email).FirstOrDefault();
            var writeId = myContext.Writers.Where(x => x.Email == useremail).Select(x => x.Id).FirstOrDefault();
            ViewBag.v1 = myContext.Blogs.Count().ToString();
            ViewBag.v2 = myContext.Blogs.Where(x => x.WriterId == 1).Count();
            ViewBag.v3 = myContext.Categories.Count();
            return View();
        }
    }
}
