using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Resturant.Data;
using Resturant.Models;
using Resturant.Models.ViewModel;
using Resturant.Utility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Resturant.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }


        [Authorize]
        public async Task<IActionResult> Index()

        {
            IndexViewModel IndexVM = new IndexViewModel()
            {
                MenuItem = await _db.MenuItem.Include(s => s.subCategory).Include(s => s.Category).ToListAsync(),
                Category = await _db.Categories.ToListAsync(),
                Coupon = await _db.Coupon.Where(c=>c.IsActive==true).ToListAsync()
            };
            return View(IndexVM);
        }

        public async Task<IActionResult> Details(int id)
        {
            var menuItemFromDb = await _db.MenuItem.Include(m => m.Category).Include(m => m.subCategory).Where(m => m.Id == id).FirstOrDefaultAsync();
            ShoppingCart carObj = new ShoppingCart
            {
                MenuItem = menuItemFromDb,
                MenuItemId = menuItemFromDb.Id
            };
            return View(carObj);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Details(ShoppingCart CartObject)
        {
            CartObject.Id = 0;
            if (ModelState.IsValid)
            {
                var claimsIdentity = (ClaimsIdentity)this.User.Identity;
                var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
                CartObject.ApplicationUserId = claim.Value;

                ShoppingCart cartFromDb = await _db.ShoppingCart.Where(c => c.ApplicationUserId == CartObject.ApplicationUserId
                                                && c.MenuItemId == CartObject.MenuItemId).FirstOrDefaultAsync();

                if (cartFromDb == null)
                {
                    await _db.ShoppingCart.AddAsync(CartObject);
                }
                else
                {
                    cartFromDb.Count = cartFromDb.Count + CartObject.Count;
                }
                await _db.SaveChangesAsync();

                var count = _db.ShoppingCart.Where(c => c.ApplicationUserId == CartObject.ApplicationUserId).ToList().Count();
                HttpContext.Session.SetInt32(SD.ssShoppingCartCount, count);

                return RedirectToAction("Index");
            }
            else
            {

                var menuItemFromDb = await _db.MenuItem.Include(m => m.Category).Include(m => m.subCategory).Where(m => m.Id == CartObject.MenuItemId).FirstOrDefaultAsync();

                ShoppingCart cartObj = new ShoppingCart()
                {
                    MenuItem = menuItemFromDb,
                    MenuItemId = menuItemFromDb.Id
                };

                return View(cartObj);
            }
        }







        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
