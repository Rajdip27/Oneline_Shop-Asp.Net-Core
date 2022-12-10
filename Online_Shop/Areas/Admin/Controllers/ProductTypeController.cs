using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Online_Shop.Data;
using Online_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Shop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ProductTypeController : Controller
    {
        private ApplicationDbContext _db;
        public ProductTypeController(ApplicationDbContext db)
        {
            _db = db;
        }
        //[AllowAnonymous]
        
        public IActionResult Index()
        {
            return View(_db.productTypes.ToList());
        }
      
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductType product)
        {
            if (ModelState.IsValid)
            {
                _db.productTypes.Add(product);
                await _db.SaveChangesAsync();
                TempData["Save"] = "Product Type Has Been Saved!";
                return RedirectToAction(actionName:nameof(Index));


            }
            return View(product);
        }
        
        public ActionResult Edit(int ? id)
        {
            var ProductType = _db.productTypes.Find(id);
            if (id == null)
            {
                return NotFound();

            }
           
            return View(ProductType);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProductType product)
        {
            if (ModelState.IsValid)
            {
                _db.Update(product);
                await _db.SaveChangesAsync();
                TempData["Update"] = "Product Type Has Been Update Successful ";
                return RedirectToAction(actionName: nameof(Index));


            }
            return View(product);
        }
        

        public ActionResult Details(int? id)
        {
            var ProductType = _db.productTypes.Find(id);
            if (id == null)
            {
                return NotFound();

            }

            return View(ProductType);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public  IActionResult Details(ProductType product)
        //{

        //    return  RedirectToAction(actionName: nameof(Index));
        //}

        
        public ActionResult Delete(int? id)
        {
            var ProductType = _db.productTypes.Find(id);
            if (id == null)
            {
                return NotFound();

            }

            return View(ProductType);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id, ProductType product)
        {
            if (id == null)
            {
                return NotFound();

            }
            if (id!= product.Id)
            {
                return NotFound();

            }
            var productType = _db.productTypes.Find(id);
            if(productType == null)
            {
                return NotFound();

            }
            if (ModelState.IsValid)
            {
                _db.Remove(productType);
                await _db.SaveChangesAsync();
                TempData["Delete"] = "Product Type Has Been Delete Successful ";
                return RedirectToAction(actionName: nameof(Index));


            }
            return View(product);
        }

        
    }
}
