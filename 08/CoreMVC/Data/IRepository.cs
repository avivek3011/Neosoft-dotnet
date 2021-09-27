﻿using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IRepository
    {
        IEnumerable<SuperHero> GetSuperHeroes();
        SuperHero GetSuperHeroById(int id);
        void Add(SuperHero superHero);
        void Edit(SuperHero superhero);
        void DeleteSuperHeroById(int id);
        void AddSuperPower(SuperPower superPower);
    }
}
