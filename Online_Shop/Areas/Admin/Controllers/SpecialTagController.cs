using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Online_Shop.Data;
using Online_Shop.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Shop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class SpecialTagController : Controller
    {
        private ApplicationDbContext _db;
        public SpecialTagController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.specialTags.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(specialTag product)
        {
            if (ModelState.IsValid)
            { 
                 _db.specialTags.Add(product);
                 await _db.SaveChangesAsync();
                TempData["Save"] = "Product Type Has Been Saved!";
                return RedirectToAction(actionName:nameof(Index));

            }
            return View(product);
        }
        public IActionResult Edit( int? id)
        {
            var specialTag = _db.specialTags.Find(id);
            if(specialTag == null)
            {
                return NotFound();
            }
            return View(specialTag);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(specialTag product)
        {
            if (ModelState.IsValid)
            {
                _db.specialTags.Update(product);
                await _db.SaveChangesAsync();
                TempData["Update"] = "Product Type Has Been Update Successful ";
                return RedirectToAction(actionName: nameof(Index));

            }
            return View(product);
        }

        public IActionResult Details(int? id)
        {
            var Specialtg= _db.specialTags.Find(id);
            if(Specialtg == null)
            {
                return NotFound();
            }
            return View(Specialtg);
        }
        public IActionResult Delete ( int? id)
        {
            var specialTag = _db.specialTags.Find(id);
            if(specialTag == null)
            {
                return NotFound();
            }
            return View(specialTag);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id,specialTag product)
            
        {
            if (id == null)
            {
                return NotFound();

            }
            if (id != product.Id)
            {
                return NotFound();


            }

            if (ModelState.IsValid)
            {
                _db.specialTags.Remove(product);
                await _db.SaveChangesAsync();
                TempData["Delete"] = "Product Type Has Been Delete Successful ";
                return RedirectToAction(actionName: nameof(Index));

            }
            return View(product);
        }


    }
}
