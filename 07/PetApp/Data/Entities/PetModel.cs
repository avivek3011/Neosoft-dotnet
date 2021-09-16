using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Data.Entities
{
    public partial class PetModel : DbContext
    {
        public PetModel()
            : base("name=PetModel")
        {
        }

        public virtual DbSet<Cat> Cats { get; set; }
        public virtual DbSet<catType> catTypes { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<FoodType> FoodTypes { get; set; }
        public virtual DbSet<FurType> FurTypes { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Meal> Meals { get; set; }
        public virtual DbSet<Login> Logins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cat>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Cat>()
                .Property(e => e.legLength)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Cat>()
                .Property(e => e.ribcage)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Cat>()
                .HasMany(e => e.Meals)
                .WithRequired(e => e.Cat)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<catType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<catType>()
                .HasMany(e => e.Cats)
                .WithOptional(e => e.catType1)
                .HasForeignKey(e => e.CatType);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Namee)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Zipcode)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<FoodType>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<FoodType>()
                .HasMany(e => e.Meals)
                .WithRequired(e => e.FoodType1)
                .HasForeignKey(e => e.FoodType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FurType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<FurType>()
                .HasMany(e => e.Cats)
                .WithOptional(e => e.FurType1)
                .HasForeignKey(e => e.FurType);

            modelBuilder.Entity<Gender>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Gender>()
                .HasMany(e => e.Cats)
                .WithRequired(e => e.Gender)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
