using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VodusAssesmentMVC.Models;
using VodusAssesmentMVC.Data;
using Microsoft.EntityFrameworkCore;

namespace VodusAssesmentMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductDbContext _context;
        public ProductController (ProductDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var prod = await _context.Products.ToListAsync();
            return View(prod);
        }

        public async Task<IActionResult> Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}