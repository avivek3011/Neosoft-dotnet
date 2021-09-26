using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

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
    }
}
