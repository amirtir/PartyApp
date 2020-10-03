using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyApp.Models;

namespace PartyApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create() => View();


        [HttpPost]
        public ActionResult Create(Guest guest)
        {
            if (ModelState.IsValid)
            {
                Repository.Insert(guest);
                return View("SuccessRegister", guest);
            }

            return View(guest);
        }

        public IActionResult List() => View(Repository.Guests);

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
