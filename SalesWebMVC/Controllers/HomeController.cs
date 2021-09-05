using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models.ViewModels;
using System;
using System.Diagnostics;

namespace SalesWebMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "SallesWebApp - Sistema de vendas feito com C#.";
            ViewData["Developer"] = "Aretha Martins.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Email:";
            ViewData["Email"] = "arealbmartinsan@gmail.com";

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
