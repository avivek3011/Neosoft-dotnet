using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Data;

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
    }
}
