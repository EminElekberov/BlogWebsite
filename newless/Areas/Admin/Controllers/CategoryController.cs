using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Entity.Concencrate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace newless.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index(int page = 1)
        {
            var values = categoryManager.GetList().ToPagedList(page, 1);
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category p)
        {
            p.Status = true;
            categoryManager.TAdd(p);
            return Redirect("/Admin/Category/Index");
        }
        public IActionResult CategoryDelete(int id)
        {
            var value = categoryManager.GetById(id);
            categoryManager.TDelete(value);
            return RedirectToAction("Index");
        }
    }
}
