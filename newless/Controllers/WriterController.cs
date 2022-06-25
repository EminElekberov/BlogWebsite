using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Entity;
using Entity.Concencrate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<AppUser> _userManager;

        public WriterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

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
        public async Task<IActionResult> WriterEditProfile()
        {
            // UserManager userManager = new UserManager(new EfUserRepository());
            // var Username = User.Identity.Name;
            // var userEmail = mycontext.Users.Where(x => x.UserName == Username).Select(x => x.Email).FirstOrDefault();
            // ViewBag.v = Username;
            // var writerName = mycontext.Writers.Where(x => x.Email == Username).Select(x => x.Id).FirstOrDefault();
            //// var value = writerManager.GetById(writerName);
            // var id = mycontext.Users.Where(x => x.Email == userEmail).Select(y => y.Id).FirstOrDefault();
            var values = await _userManager.FindByNameAsync(User.Identity.Name);

            var model = new UserUpdateViewModel();

            model.Email = values.Email;
            model.NameSurname = values.NameSurname;
            model.ImageUrl = values.ImageUrl;
            model.Username = values.UserName;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> WriterEditProfile(UserUpdateViewModel model)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            values.Email = model.Email;
            values.NameSurname = model.NameSurname;
            values.ImageUrl = model.ImageUrl;
            values.UserName = model.Username;
            values.PasswordHash = _userManager.PasswordHasher.HashPassword(values, model.Password);
            var result = await _userManager.UpdateAsync(values);
            return RedirectToAction("Index", "Dashboard");
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
