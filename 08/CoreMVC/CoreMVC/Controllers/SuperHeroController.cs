using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using CoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Data;
using System.Data;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Net;



namespace CoreMVC.Controllers
{
    [Route("[controller]/[action]")]
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
        [HttpGet("{id}")]
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
            if (ModelState.IsValid)
            {
                repo.Add(Mapper.Map(superHero));
                return RedirectToAction("Index");
            }
            else
                return View(superHero);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            if (id > 0)
            {
                var data = repo.GetSuperHeroById(id);
                if (data != null)
                {
                    return View(Mapper.Map(data));
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            else 
            {
                return RedirectToAction("Index");
            }
        }
        [HttpPost]
        public IActionResult Update(SuperHero sup)
        {
            if (ModelState.IsValid)
            {
                repo.Edit(Mapper.Map(sup));
                return RedirectToAction("Index");
            }
            else
            {
                return View(sup);
            }
        }

        public IActionResult Delete(int id)
        {
            repo.DeleteSuperHeroById(id);
            return RedirectToAction("Index");
        }
    }
}
