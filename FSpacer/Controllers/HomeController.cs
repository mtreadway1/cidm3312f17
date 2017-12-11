using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FSpacer.Data;
using FSpacer.Models;

namespace FSpacer.Controllers
{
    public class HomeController : Controller
    {

        private readonly AGCDbContext _context;

        public HomeController(AGCDbContext context)
        {
            _context = context;
        }


        public IActionResult SpacerCardInput()
        {

            return View();
        }

        public IActionResult Index()
        {

            var items = _context.SpacerCards.OrderByDescending<SpacerCard, int>(SpacerCard => SpacerCard.ID).Take(5);
            var test = items.ToList();


            return View(test);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
