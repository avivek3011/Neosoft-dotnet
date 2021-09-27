using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Data;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CoreMVC.Controllers
{
    public class SuperHeroController : Controller
    {
        private readonly IRepository repo;
        public SuperHeroController(IRepository _repo)
        {
            repo = _repo;
        }
        public IActionResult Index()
        {
            return View(Mapper.Map(repo.GetSuperHeroes()));
        }
        public IActionResult Details(int id)
        {
            return View(Mapper.Map(repo.GetSuperHeroById(id)));
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(SuperHero superHero)
        {
            if (ModelState.IsValid) {
                repo.Add(Mapper.Map(superHero));
                return RedirectToAction("Index");
            }
            else
                return View(superHero);
        }
    }
}
