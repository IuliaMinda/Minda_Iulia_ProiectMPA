﻿using Microsoft.AspNetCore.Mvc;
using Minda_Iulia_ProiectMPA.Data;
using Minda_Iulia_ProiectMPA.Models;
using System.Diagnostics;

namespace Minda_Iulia_ProiectMPA.Controllers
{
    public class HomeController : Controller
    {
        private readonly RentalContext _context;

        public HomeController(RentalContext context)
        {
            _context = context;
        }

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
    }
}