using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Civilized.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Civilized.Controllers
{
    public class HomeController : Controller
    {
        private CivDbContext db = new CivDbContext();

        public IActionResult Configuration()
        {
            ViewBag.CivilizationId = new SelectList(db.Civilizations, "CivilizationId", "Name");
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult HelloAjax()
        {
            return Content("Hello from the controller!", "text/plain");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
