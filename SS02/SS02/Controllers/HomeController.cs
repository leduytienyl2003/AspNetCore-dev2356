﻿using Microsoft.AspNetCore.Mvc;
using SS02.Models;
using System.Diagnostics;

namespace SS02.Controllers
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
            ViewData["messageVD"] = "dữ liệu trong Viewdata";
            ViewBag.messageVB = "dữ liệu trong ViewBag";
            TempData["messageTD"] = "dữ liệu lưu trong Tempdata";
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
