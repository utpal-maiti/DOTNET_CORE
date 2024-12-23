using System.Diagnostics;

using App_ClassLibrary;

using App_Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace App_Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController()
        {
        }

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        // GET: Home
        public ActionResult Index()
        {
            Employee emp = new Employee
            {
                Id = 101,
                Name = "Abhishek",
                Location = "Bangalore",
                Salary = 12345
            };

            ViewBag.testName = "Pragim Tech";

            return View("TestView", emp);

            //return RedirectToAction("Home");
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
