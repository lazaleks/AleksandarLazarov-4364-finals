using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _4364.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace _4364.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Convert(decimal temp)
        {
            var convertedTemperature = ((temp - 32) * 5 / 9);
            return View(OpenModelPopup("Converted temperature is : " + convertedTemperature.ToString()));
        }
        public IActionResult OpenModelPopup(string message)
        {
            return View(message);
        }

        public IActionResult ReadText()
        {
            var readTextModel = new ReadTextModel { Text = System.IO.File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Exam.txt")) };
            return View(readTextModel);
        }

    }
}
