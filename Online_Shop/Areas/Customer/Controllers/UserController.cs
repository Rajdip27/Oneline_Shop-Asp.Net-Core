﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Online_Shop.Data;
using Online_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Shop.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class UserController : Controller
    {
        UserManager<IdentityUser> _userManager;
        ApplicationDbContext _db;
        public UserController(UserManager<IdentityUser> userManager,ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;

        }

        public IActionResult Index()
        {
            return View(_db.ApplicationUsers.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ApplicationUser user)
        {
            if (ModelState.IsValid)
            {
                var result = await _userManager.CreateAsync(user, user.PasswordHash);
                if (result.Succeeded)
                {
                    TempData["Save"] = "User Has Been Create Successfully";
                    return RedirectToAction(nameof(Index));

                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }

            }
           
           

            return View();

        }
        public async Task<IActionResult> Edit(string id)
        {
            var user = _db.ApplicationUsers.FirstOrDefault(c => c.Id == id);
            if (user==null)
            {
                return NotFound();
            }
            return View(user);

        }
        [HttpPost]
        public async Task<IActionResult>Edit(ApplicationUser user)
        {
            var userinfo = _db.ApplicationUsers.FirstOrDefault(c => c.Id == user.Id);
            if (userinfo == null)
            {
                return NotFound();
            }
            userinfo.FirstName = user.FirstName;
            userinfo.LastName = user.LastName;
            var result =await _userManager.UpdateAsync(userinfo);
            if (result.Succeeded)
            {
                TempData["Save"] = "User Has Been Update Successfully";
                return RedirectToAction(nameof(Index));

            }

            return View();
        }
        public async Task<IActionResult> Details(string id)
        {
            var user = _db.ApplicationUsers.FirstOrDefault(c => c.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);

        }
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var user = _db.ApplicationUsers.FirstOrDefault(c => c.Id == id);
            if (user == null)
            {
                return NotFound();

            }
            return View(user);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(ApplicationUser user)
        {
            var userinfo = _db.ApplicationUsers.FirstOrDefault(c => c.Id == user.Id);
            if (userinfo == null)
            {
                return NotFound();
            }
            _db.ApplicationUsers.Remove(userinfo);
            int rowAffected = _db.SaveChanges();
            if (rowAffected > 0)
            {
                TempData["save"] = "User has been Delete successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(userinfo);

           

        }
        public async Task<IActionResult> Lockout(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var user = _db.ApplicationUsers.FirstOrDefault(c => c.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Lockout(ApplicationUser user)
        {
            var userInfo = _db.ApplicationUsers.FirstOrDefault(c => c.Id == user.Id);
            if (userInfo == null)
            {
                return NotFound();

            }
            userInfo.LockoutEnd = DateTime.Now.AddYears(100);
            int rowAffected = _db.SaveChanges();
            if (rowAffected > 0)
            {
                TempData["save"] = "User has been lockout successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(userInfo);
        }
        public async Task<IActionResult> Active(string id)
        {
            var user = _db.ApplicationUsers.FirstOrDefault(c => c.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }
        [HttpPost]
        public async Task<IActionResult> Active(ApplicationUser user)
        {
            var userInfo = _db.ApplicationUsers.FirstOrDefault(c => c.Id == user.Id);
            if (userInfo == null)
            {
                return NotFound();
            }
            //userInfo.LockoutEnd = null;
            userInfo.LockoutEnd = DateTime.Now.AddDays(-1);
            int rowAffected = _db.SaveChanges();
            if (rowAffected > 0)
            {
                TempData["save"] = "User has been Active successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(userInfo);

        }


    }
}
