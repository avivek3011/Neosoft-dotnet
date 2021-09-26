using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Data;
using Data.Entities;
using RestService.Models;

namespace RestService.Controllers
{
    public class PetController : ApiController
    {
        ICatRepository repo;
        public PetController()
        {
            repo = new CatRepository(new PetModel());
        }
        [HttpGet]

        public IHttpActionResult Get()
        {
            var cats = repo.GetCats();
            List<CatModel> mappedCats = new List<CatModel>();
            foreach (var cat in cats)
            {
                mappedCats.Add(Mapper.Map(cat));
            }
            if (cats.Count() > 0)
            {
                return Ok(mappedCats);
            }
            else
                return NotFound();
        }
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var cat = repo.GetCatById(id);
            if (cat != null)
            {
                return Ok(Mapper.Map(cat));
            }
            else
                return NotFound();
        }
        [HttpPost]
        public IHttpActionResult Post(CatModel cat)
        {
            if (!ModelState.IsValid)
                return BadRequest("Ibvalid data");
            repo.AddCat(Mapper.Map(cat));
            return Created<CatModel>("Post", cat);
        }
        [HttpPut]
        public IHttpActionResult Put(CatModel cat)
        {
            var catFound = repo.GetCatById(cat.Id);
            if (catFound != null)
            {
                repo.UpdateCat(Mapper.Map(cat));
                return Ok();
            }
            else
                return NotFound();
        }
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest();
            var catFound = repo.GetCatById(id);
            if (catFound != null)
            {
                repo.DeleteCat(id);
                return Ok();
            }
            else
                return NotFound();
        }
    }
}
