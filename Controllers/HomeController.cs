using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectBookStore.Models;
using System.Diagnostics;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ProjectBookStore.Data;
using System.Linq;

namespace ProjectBookStore.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;

        }
        private readonly ApplicationDbContext _context;
        public IActionResult Index()
        {
            ViewBag.list =_context.book.ToList();
            return View();
        }
        private void FetchData()
        {

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
