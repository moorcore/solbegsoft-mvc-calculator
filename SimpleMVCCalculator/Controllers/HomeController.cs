using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleMVCCalculator.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleMVCCalculator.Controllers
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

        [HttpPost]
        public IActionResult Index(Calculator calc)
        {
            double a, b;

            a = calc.value1;
            b = calc.value2;

            if (calc.calculate == "+")
            {
                calc.result = a + b;
                calc.notification = "Addition:";
                ViewData["Notification"] = calc.notification;
            }
            if (calc.calculate == "-")
            {
                calc.result = a - b;
                calc.notification = "Substraction:";
                ViewData["Notification"] = calc.notification;
            }
            if (calc.calculate == "x")
            {
                calc.result = a * b;
                calc.notification = "Multiplication:";
                ViewData["Notification"] = calc.notification;
            }
            if (calc.calculate == "÷")
            {
                if (b != 0)
                {
                    calc.result = a / b;
                    calc.notification = "Division:";
                    ViewData["Notification"] = calc.notification;
                }  
                else
                {
                    calc.notification = "Can not divide by zero!";
                    ViewData["Notification"] = calc.notification;
                }
                    
            }

            ViewData["Result"] = calc.result;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Info()
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
