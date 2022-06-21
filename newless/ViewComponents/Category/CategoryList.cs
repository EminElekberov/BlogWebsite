﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newless.ViewComponents.Category
{
    public class CategoryList:ViewComponent
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IViewComponentResult Invoke()
        {
            var vaalues = cm.GetList();
            return View(vaalues);
        }
    }
}