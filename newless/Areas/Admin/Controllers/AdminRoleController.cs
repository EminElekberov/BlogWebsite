using Entity;
using Entity.Concencrate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using newless.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newless.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminRoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        public AdminRoleController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult Index() 
        {
            var values = _roleManager.Roles.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AppRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AppRole(RoleViewModel roleView)
        {
            AppRole role = new AppRole
            {
                Name=roleView.Name
            };
            var result = await _roleManager.CreateAsync(role);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateRole(int id)
        {
            var values = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            RoleUpdateViewModel roleUpdateViewModel = new RoleUpdateViewModel
            {
                Id = values.Id,
                name = values.Name
            };
            return View(roleUpdateViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateRole(RoleUpdateViewModel model)
        {
            var values = _roleManager.Roles.Where(x => x.Id == model.Id).FirstOrDefault();
            values.Name = model.name;
            var result = await _roleManager.UpdateAsync(values);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public async Task<IActionResult> DeleteRole(int id)
        {
            var values = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            var result = await _roleManager.DeleteAsync(values);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult UserRoleList()
        {
            var values = _userManager.Users.ToList();
            return View(values);
        }
        public async Task<IActionResult> AssignRole(int id)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            var roles = _roleManager.Roles.ToList();
            TempData["UserId"] = user.Id;
            var userroles = await _userManager.GetRolesAsync(user);
            List<RoleAssignViewModel> model = new List<RoleAssignViewModel>();
            foreach (var item in roles)
            {
                RoleAssignViewModel m = new RoleAssignViewModel();
                m.RoleId = item.Id;
                m.Name = item.Name;
                m.Exists = userroles.Contains(item.Name);
                model.Add(m);
            }
            return View();
        }
    }
}
