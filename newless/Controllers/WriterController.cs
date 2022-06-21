using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Entity.Concencrate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using newless.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace newless.Controllers
{
    public class WriterController : Controller
    {
        MyContext mycontext = new MyContext();
        WriterManager writerManager = new WriterManager(new EfWriterRepository());
        public IActionResult Index()
        {
            var useremail = User.Identity.Name;
            ViewBag.v = useremail;
            var writerName = mycontext.Writers.Where(x => x.Email == useremail).Select(x => x.Name).FirstOrDefault();
            ViewBag.v2 = writerName;
            return View();
        }
        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }
        [HttpGet]
        public IActionResult WriterEditProfile()
        {

            var Username = User.Identity.Name;
            var userEmail = mycontext.Users.Where(x => x.UserName == Username).Select(x => x.Email).FirstOrDefault();
            ViewBag.v = Username;
            var writerName = mycontext.Writers.Where(x => x.Email == Username).Select(x => x.Id).FirstOrDefault();
            var value = writerManager.GetById(writerName);
            return View(value);
        }
        [HttpPost]
        public IActionResult WriterEditProfile(Writer p)
        {
            WriterValidator rules = new WriterValidator();
            ValidationResult validationResult = rules.Validate(p);
            if (validationResult.IsValid)
            {
                var db = mycontext.Writers.Find(1);
                p.Id = db.Id;
                writerManager.TUpdate(p);
                return RedirectToAction("INdex","Dashboard");
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
        public IActionResult WriterAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage p)
        {
            Writer w = new Writer();
            if (p.Image != null)
            {
                var extension = Path.GetExtension(p.Image.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "Wwwroot/WriterImage/", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                p.Image.CopyTo(stream);
                w.Image = newimagename;
            }
            w.Email = p.Email;
            w.Name = p.Name;
            w.Password = p.Password;
            w.Status = true;
            w.About = p.About;
            writerManager.TAdd(w);
            return RedirectToAction("Index", "Dashboard");

        }
    }
}
