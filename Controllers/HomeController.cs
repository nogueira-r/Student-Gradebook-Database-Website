using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GradesBooks.Models;

namespace GradesBook.Controllers
{
    public class HomeController : Controller
    {
        private StudentContext context { get; set; }

        public HomeController(StudentContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}