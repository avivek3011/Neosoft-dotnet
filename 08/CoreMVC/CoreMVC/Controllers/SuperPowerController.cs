using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVC.Controllers
{
    public class SuperPowerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
