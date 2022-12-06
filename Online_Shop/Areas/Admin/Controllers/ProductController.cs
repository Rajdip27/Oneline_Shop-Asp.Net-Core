using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Online_Shop.Data;
using Online_Shop.Models;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Shop.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class ProductController : Controller
    {
        private ApplicationDbContext _db;
        private IHostingEnvironment _he;
        public ProductController(ApplicationDbContext db,IHostingEnvironment he)
        {
            _db = db;
            _he = he;
        }
        
        public IActionResult Index()
        {
            return View(_db.products.Include(c=>c.ProductTypes).Include(c=>c.specialTag).ToList());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(decimal? lowAmount,decimal? largeAmount )
        {
            var Products = _db.products.Include(c => c.ProductTypes).Include(c => c.specialTag).Where(c => c.Price >= largeAmount && c.Price <= largeAmount).ToList();
            if(largeAmount==null || largeAmount == null)
            {
            Products = _db.products.Include(c => c.ProductTypes).Include(c => c.specialTag).ToList();
            }

            return View(Products);



        }

        public IActionResult Create()

        {
            ViewData["productTypeId"] = new SelectList(_db.productTypes.ToList(), "Id", "Producttype");
            ViewData["TagId"] = new SelectList(_db.specialTags.ToList(), "Id", "specialTageName");

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
       

        public async Task<IActionResult> Create(Products products,IFormFile image)
        {
            if (ModelState.IsValid)

            {
                var SarchProduct = _db.products.FirstOrDefault(c => c.Name == products.Name);
                if (SarchProduct!=null)
                {
                    ViewBag.message = "This Product Is already exits";
                    ViewData["productTypeId"] = new SelectList(_db.productTypes.ToList(), "Id", "Producttype");
                    ViewData["TagId"] = new SelectList(_db.specialTags.ToList(), "Id", "specialTageName");

                    return View(products);
                }

                if (image != null)
                {
                    var name=Path.Combine(_he.WebRootPath+"/Images",Path.GetFileName(image.FileName));  
                    await image.CopyToAsync(new FileStream(name, FileMode.Create));
                    products.Image = "Images/" + image.FileName;
                }
                if (image == null)
                {
                     
                    products.Image = "Images/noimage.PNG"; 

                }
                _db.products.Add(products);
                await _db.SaveChangesAsync();
                return RedirectToAction(actionName:nameof(Index));

            }
            return View(products);
        }





        //GET Edit Action Method//
        public ActionResult Edit(int? id)
        {

            ViewData["productTypeId"] = new SelectList(_db.productTypes.ToList(), "Id", "Producttype");
            ViewData["TagId"] = new SelectList(_db.specialTags.ToList(), "Id", "specialTageName");
            if (id == null)
            {
                return NotFound();
            }
            var products = _db.products.Include(c => c.ProductTypes).Include(c => c.specialTag).FirstOrDefault(c => c.Id == id);
            if (products == null)
            {
                return NotFound();

            }
            return View(products);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Products products, IFormFile image)
        {
            if (ModelState.IsValid)
            {
                var SarchProduct = _db.products.FirstOrDefault(c => c.Name == products.Name);

                if (SarchProduct!=null)
                {
                    ViewBag.message = "This Product Is already exits";
                    ViewData["productTypeId"] = new SelectList(_db.productTypes.ToList(), "Id", "Producttype");
                    ViewData["TagId"] = new SelectList(_db.specialTags.ToList(), "Id", "specialTageName");

                    return View(products);

                }

                if (image != null)
                {
                    var name = Path.Combine(_he.WebRootPath + "/Images", Path.GetFileName(image.FileName));
                    await image.CopyToAsync(new FileStream(name, FileMode.Create));
                    products.Image = "Images/" + image.FileName;
                }
                if (image == null)
                {

                    products.Image = "Images/noimage.PNG";

                }
                _db.products.Update(products);
                await _db.SaveChangesAsync();
                return RedirectToAction(actionName: nameof(Index));

            }
            return View(products);


        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Products = _db.products.Include(c => c.ProductTypes).Include(c => c.specialTag).FirstOrDefault(c => c.Id == id);
            if (Products==null)
            {
                return NotFound();
            }

            return View(Products);
        }

        //Delect Action//
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Product = _db.products.Include(c=>c.specialTag).Include(c=>c.ProductTypes).Where(c => c.Id == id).FirstOrDefault();
            if (Product == null)
            {
                return NotFound();
            }

            return View(Product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = _db.products.FirstOrDefault(c => c.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            _db.products.Remove(product);
            await _db.SaveChangesAsync();
            

            return RedirectToAction(actionName: nameof(Index));
        }
    }
}
