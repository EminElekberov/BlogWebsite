using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Entity.Concencrate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newless.Controllers
{
    public class BlogController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        BlogManager bm = new BlogManager(new EfBlogRepository());
        MyContext mycontext = new MyContext();

        public IActionResult Index()
        {
            var values = bm.GetCategoryList();
            return View(values);
        }
        public IActionResult BlogReadAll(int id)
        {
            if (id==0)
            {
                return NotFound();
            }
            var Id = bm.GetById(id);

            return View(Id);
        }


        public IActionResult BlogListByWriter()
        {

            var username = User.Identity.Name;
            var useremail = mycontext.Users.Where(x => x.UserName == username).Select(x => x.Email).FirstOrDefault();
            var writerId = mycontext.Writers.Where(x => x.Email == useremail).Select(x => x.Id).FirstOrDefault();
            var values = bm.GetListWIthCategoryByWriterBm(writerId);
            //ViewBag.v = useremail;
            //var writerName = mycontext.Writers.Where(x => x.Email == useremail).Select(x => x.Id).FirstOrDefault();
            //var values = bm.GetListWIthCategoryByWriterBm(writerName );
            return View(values);
        }
        public async Task<IActionResult> BlogAdd()
        {
            List<SelectListItem> categoryValues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Name,
                                                       Value = x.Id.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryValues;
            return View();
        }
        [HttpPost]
        public IActionResult BlogAdd(Blog w)
        {
            var username = User.Identity.Name;
            var useremail = mycontext.Users.Where(x => x.UserName == username).Select(x => x.Email).FirstOrDefault();
            var writerId = mycontext.Writers.Where(x => x.Email == useremail).Select(x => x.Id).FirstOrDefault();
            MyContext m = new MyContext();
            BlogValidator vm = new BlogValidator();
            ValidationResult validationResult = vm.Validate(w);
            if (validationResult.IsValid)
            {

                w.Status = true;
                w.CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                w.WriterId = writerId;
                bm.TAdd(w);
                //m.SaveChanges()
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult DeleteBlog(int id)
        {
            var value = bm.GetById(id);
            bm.TDelete(value);
            return RedirectToAction("Index","blog");
        }
        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            var blogValue = bm.GetById(id);
            List<SelectListItem> categoryValues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Name,
                                                       Value = x.Id.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryValues;
            return View(blogValue);
        }
        [HttpPost]
        public IActionResult EditBlog(Blog p)
        {

            var username = User.Identity.Name;
            var usermail = mycontext.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerId = mycontext.Writers.Where(x => x.Email == usermail).Select(y => y.Id).FirstOrDefault();

            p.WriterId = writerId;
            p.CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.Status = true;
            bm.TUpdate(p);
            return RedirectToAction("BlogListByWriter");
        }
    }
}
