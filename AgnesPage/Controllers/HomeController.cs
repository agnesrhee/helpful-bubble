using AgnesPage.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AgnesPage.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IWebHostEnvironment env ,ILogger<HomeController> logger)
        {
            _env = env;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutMe()
        {
            var imageDirectory = Path.Combine(_env.WebRootPath, "images");
            var imageFiles = Directory.GetFiles(imageDirectory)
                                       .Select(f => "~/images/" + Path.GetFileName(f)) // Get relative paths for the view
                                       .ToList();

            return View(imageFiles);
        }

        public IActionResult Resume()
        {
            return View();
        }

        public IActionResult Projects()
        {
            return View();
        }

        public IActionResult Salad()
        {
            return View();
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