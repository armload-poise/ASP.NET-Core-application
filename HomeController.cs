// Controllers/HomeController.cs
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models;

namespace OnlineShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Product> products = _context.Products.ToList();
            return View(products);
        }

        public IActionResult AddToCart(int id)
        {
            Product product = _context.Products.Find(id);
            if (product != null)
            {
                // Implement cart logic here (e.g., use sessions)
            }

            return RedirectToAction("Index");
        }

        public IActionResult Cart()
        {
            // Implement cart logic here
            return View();
        }
    }
}

