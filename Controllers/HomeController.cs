using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sanctum.Models;

namespace Sanctum.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(int usernameID, string password)
        {
            var u_p = false;
            var chara = 8;
            //ViewData["Message"] = "Are you seeing this";
            while (u_p) {


                if (usernameID == 9)
                {
                    u_p = true;

                }
                else if (Convert.ToInt32(password.Length) >= chara)
                {
                    u_p = true;
                }
                else
                {
                    Console.WriteLine("Wrong Username or Password -- Try Again");
                    u_p = false;

                }
            }

            return View(new List<SancModel>());
        }
        public IActionResult Buildig()
        {

            return View();
        }

        public IActionResult Room()
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
