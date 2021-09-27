using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Data
{
    public class Repository : IRepository
    {
        SuperHeroContext _Context;
        public Repository(SuperHeroContext context)
        {
            _Context = context;
        }
        public IEnumerable<SuperHero> GetSuperHeroes()
        {
            return _Context.SuperHeroes.Include("SuperPowers").ToList();
        }
        public SuperHero GetSuperHeroById(int id)
        {
            if (id > 0)
            {
                var x= _Context.SuperHeroes.Where(s => s.Id == id).Include("SuperPowers").FirstOrDefault();
                return x;
            }
            else
                return null;
        }
        public void Add(SuperHero superHero)
        {
            if (superHero != null)
            {
                _Context.Add(superHero);
                _Context.SaveChanges();
            }
        }
    }
}
