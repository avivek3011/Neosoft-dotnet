using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class SuperHeroContext:DbContext
    {
        public SuperHeroContext()
        {

        }
        public SuperHeroContext(DbContextOptions options):base(options)
        {
            
        }
        // this method will add seed data to the database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SuperHero>().HasData(new SuperHero() { Id = 1, Name = "Peter Parker", Alias = "Superman", HideOuts = "NYC apartment" });
            modelBuilder.Entity<SuperHero>().HasData(new SuperHero() { Id = 2, Name = "Tony Stark", Alias = "Ironman", HideOuts = "Dumpyard" });
            modelBuilder.Entity<SuperHero>().HasData(new SuperHero() { Id = 3, Name = "Thor", Alias = "Thor", HideOuts = "Asgard" });
            modelBuilder.Entity<SuperHero>().HasData(new SuperHero() { Id = 4, Name = "Gangadhar",Alias = "Shaktiman", HideOuts = "tenant in a village" });
        }
        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
