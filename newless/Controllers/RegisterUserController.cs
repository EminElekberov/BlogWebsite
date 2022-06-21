using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using Entity.Concencrate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newless.Controllers
{
    public class RegisterUserController : Controller
    {
        WriterManager wr = new WriterManager(new EfWriterRepository());
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer w)
        {
            WriterValidator vm = new WriterValidator();
            ValidationResult validationResult = vm.Validate(w);
            if (validationResult.IsValid)
            {

                w.Status = true;
                w.About = "denenme";
                wr.WriterAdd(w);
                return RedirectToAction("INdex", "Home");
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
    }
}
