
using Microsoft.AspNetCore.Mvc;
using Mission5.Models;
using System.Diagnostics;

namespace Mission5.Controllers
{
    public class HomeController : Controller // needs to match name of a folder in views
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
            //_logger = logger;
        //}

        public IActionResult Index()
        {
            return View();
        }

        //make action for Calculator view
        public IActionResult Calculator() // needs to maatch name of a file in home folder in views
        {
            //write our code here

            return View();
        }


        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
            //return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
