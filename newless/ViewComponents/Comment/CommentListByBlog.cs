using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newless.ViewComponents.Comment
{
    public class CommentListByBlog:ViewComponent
    {
        CommentManager cm = new CommentManager(new EfCommentyRepository());
        public IViewComponentResult Invoke(int id)
        {
            ViewBag.i = id;
            var vaalues = cm.GetList(id);
            return View(vaalues);
        }
    }
}
