using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;
using Data.Entities;
using Data;
using System.Net;
using Cat = Data.Entities.Cat;

namespace Web.Controllers
{
    [HandleError]
    public class PetController : Controller
    {
        CatRepository repo;
        public PetController()
        {
            repo = new CatRepository(new PetModel());
        }
        // GET: Pet
        [OutputCache(Duration =10,VaryByParam ="none")]
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
        // GET:PetById
        /// <summary>
        /// Gets value from Route(URL) or the Query string
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //[Authorize]
        public ActionResult GetCatById(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var cat = repo.GetCatById(id);
            if (cat == null)
                return HttpNotFound();
            return View(Mapper.Map(cat));
        }
        // GET:Form
        [HttpGet]
        public ViewResult Create()
        {
            ViewBag.CatType = new SelectList(repo.getCatType(), "Id", "Name");
            ViewBag.FurType = new SelectList(repo.getFurType(), "Id", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Create(CatViewModel cat)
        {
            if (ModelState.IsValid)
            {
                repo.AddCat(Mapper.Map(cat));
                return RedirectToAction("Index");
            }
            return View(cat);
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var cat = repo.GetCatById(id);
            if (cat == null)
            {
                return HttpNotFound();
            }
            else
            {
                ViewBag.CatType = new SelectList(repo.getCatType(), "Id", "Name",cat.CatType);
                TempData["CatType"] = cat.CatType;
                ViewBag.FurType = new SelectList(repo.getFurType(), "Id", "Name", cat.FurType);
                TempData["FurType"] = cat.FurType;
                TempData["Dob"] = cat.Dob?.ToString("MM/dd/yyyy");
            }
            return View(Mapper.MapCVM(cat));
        }
        [HttpPost]
        public ActionResult Edit(CatViewModel cat)
        {
            if (ModelState.IsValid)
            {
                repo.UpdateCat(Mapper.Map(cat));
                return RedirectToAction("Index");
            }
            return View(cat);
        }

    }
}