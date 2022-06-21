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
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentyRepository());
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialAddComment(Comment p)
        {
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.Status = true;
            p.BlogId = 1;
            cm.CommentAdd(p);
            return PartialView();
        }
        public PartialViewResult CommentListByBlog(int id)
        {
            var values = cm.GetList(id);
            return PartialView(values);
        }
    }
}
