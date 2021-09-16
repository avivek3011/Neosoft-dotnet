using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;
using Data.Entities;
using Data;

namespace Web.Controllers
{
    public class PetController : Controller
    {
        CatRepository repo;
        public PetController()
        {
            repo = new CatRepository(new PetModel());
        }
        // GET: Pet
        public ActionResult Index()
        {
            var cats = repo.GetCats();
            var data = new List<Web.Models.Cat>();
            foreach (var c in cats)
            {               
                data.Add(Mapper.Map(c));
            }
            return View(data);
        }
        public ActionResult GetCatById(int id)
        {
            var cat = repo.GetCatById(id);
            return View(Mapper.Map(cat));
        }
    }
}