using GroceryInventorySystem.Data;
using GroceryInventorySystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace GroceryInventorySystem.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("Username") == null)
            {
                return RedirectToAction("Login", "Account");
            }
            var users = _context.Users.ToList();
            return View(users);
        }
    }
}