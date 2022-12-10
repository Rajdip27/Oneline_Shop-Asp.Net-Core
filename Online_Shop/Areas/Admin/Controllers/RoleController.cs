using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Online_Shop.Areas.Admin.Models;
using Online_Shop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Shop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class RoleController : Controller
    {
        ApplicationDbContext _db;
          RoleManager<IdentityRole> _roleManager;
        UserManager<IdentityUser> _userManager;
        public RoleController(RoleManager<IdentityRole> roleManager, ApplicationDbContext db, UserManager<IdentityUser> userManager)
        {
            _roleManager = roleManager;
            _db = db;
            _userManager = userManager;

        }
        public IActionResult Index()
        {
            var roles = _roleManager.Roles.ToList();
            ViewBag.Roles = roles;
            return View();
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult>Create(string name)
        {
            
            IdentityRole role = new IdentityRole();
            role.Name = name;
            var isExist =await _roleManager.RoleExistsAsync(role.Name);
            if (isExist)
            {
                ViewBag.mgs = "This Role is Already Exist";
                ViewBag.Name = name;


                return View();
            }
            var result = await _roleManager.CreateAsync(role);
            if (result.Succeeded)
            {
                TempData["Save"] = "Role Has Been Save Successfully";
                return RedirectToAction(nameof(Index));
            }
            return View();


        }
        public async Task<IActionResult> Edit(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if(role== null)
            {
                return NotFound();
            }
            ViewBag.id = role.Id;
            ViewBag.name = role.Name;

            return View(role);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(string id,string name)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }
            role.Name = name;
            var isExist = await _roleManager.RoleExistsAsync(role.Name);
            if (isExist)
            {
                ViewBag.mgs = "This Role is Already Exist";
                ViewBag.Name = name;


                return View();
            }
            var result = await _roleManager.UpdateAsync(role);
            if (result.Succeeded)
            {
                TempData["Save"] = "Role Has Been Update Successfully";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public async Task<IActionResult> Delete(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }
            ViewBag.id = role.Id;
            ViewBag.name = role.Name;

            return View(role);
        }
        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfrim(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }
            var result =await _roleManager.DeleteAsync(role);
            if (result.Succeeded)
            {
                TempData["delete"] = "Role Has Been Delete Successfully";
                return RedirectToAction(nameof(Index));
            }

            return View(role);

        }
        public async Task<IActionResult> Assign()
        {

            ViewData["UserId"] = new SelectList(_db.ApplicationUsers.Where(c=>c.LockoutEnd<DateTime.Now||c.LockoutEnd==null).ToList(),"Id", "UserName");
            ViewData["RoleId"] = new SelectList(_roleManager.Roles.ToList(), "Name", "Name");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Assign(RoleUserVm roleUserVm)
        {
            var user = _db.ApplicationUsers.FirstOrDefault(c => c.Id == roleUserVm.UserId);
            var IsCheckRokeAssign = await _userManager.IsInRoleAsync(user, roleUserVm.RoleId);
            if (IsCheckRokeAssign)
            {
                ViewBag.mgs = "This user alreay this role";
                ViewData["UserId"] = new SelectList(_db.ApplicationUsers.Where(c => c.LockoutEnd < DateTime.Now || c.LockoutEnd == null).ToList(), "Id", "UserName");
                ViewData["RoleId"] = new SelectList(_roleManager.Roles.ToList(), "Name", "Name");

                return View();
            }
            var role = await _userManager.AddToRoleAsync(user,roleUserVm.RoleId);
            if (role.Succeeded)
            {
                TempData["delete"] = "User Role Assign!";
                return RedirectToAction(nameof(Index));
            }

            return  View();

        }
        public ActionResult AssignUserRole()
        {
            var result = from ur in _db.UserRoles
                         join r in _db.Roles on ur.RoleId equals r.Id
                         join a in _db.ApplicationUsers on ur.UserId equals a.Id
                         select new UserRoleMaping()
                         { 
                             UserId=ur.UserId,
                             RoleId=ur.RoleId,
                             UserName=a.UserName,
                             RoleName=r.Name



                         };
            ViewBag.UserRoles = result;
            return View();

        }

    }
}
