using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCNahodneCislo.Models;

namespace MVCNahodneCislo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Generator generator = new Generator();
            ViewBag.Cislo = generator.VratCislo();
            return View();
        }
    }
}