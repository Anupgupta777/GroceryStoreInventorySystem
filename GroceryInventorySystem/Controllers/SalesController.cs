using GroceryInventorySystem.Data;
using Microsoft.AspNetCore.Mvc;

namespace GroceryInventorySystem.Controllers
{
    public class SalesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SalesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("Username") == null)
            {
                return RedirectToAction("Login", "Account");
            }
            var sales = _context.Sales.ToList();

            return View(sales);
        }
    }
}