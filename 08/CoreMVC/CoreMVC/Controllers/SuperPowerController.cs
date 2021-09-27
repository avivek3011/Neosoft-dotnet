using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Data;
using CoreMVC.Models;

namespace CoreMVC.Controllers
{
    public class SuperPowerController : Controller
    {
        private IRepository repo;
        public SuperPowerController(IRepository _repo)
        {
            repo = _repo;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSuperpower(SuperPower superPower,int id)
        {
            if (ModelState.IsValid)
            {
                repo.AddSuperPower(Mapper.Map(superPower,id));
                return RedirectToAction("Index", "SuperHero");
            }
            else
                return View(superPower);
        }
        public IActionResult AddSuperpower()
        {
            return View();
        }
    }
}
