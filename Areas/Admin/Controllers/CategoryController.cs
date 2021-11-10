using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Resturant.Data;
using Resturant.Models;
using Resturant.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resturant.Areas.Admin.Controllers
{  
    [Authorize(Roles =SD.ManagerUser)]
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _db.Categories.ToListAsync());
        } 
        //Get Createa
        public ActionResult Create()
        {
            return View();
        }
        //post Create  
        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Add(category);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index)); 

            }
            return View(category);
        } 

        //Get Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if (id== null)
                {
                return NotFound();  
                }
            var category =await _db.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }
        //Edit Post 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                _db.Update(category);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }


        //Get Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var category = await _db.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirm(int? id)
        {
            var category = await _db.Categories.FindAsync(id);
            if (category == null)
            {
                return View();
            }

            _db.Categories.Remove(category);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
        //GET - DETAILS
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _db.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

    }
}
