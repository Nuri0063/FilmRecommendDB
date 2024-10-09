using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using FilmRecommend.Entities;
using FilmRecommend.Data;


FilmMoodDBContext context = new();

namespace FilmRecommend.Data
{

    //DbContext sınıfı
   public class FilmMoodDBContext : DbContext
    {
        //DbContext ile kalıtımladığımız class'a tablolarımızı EF core'un anlayacağı dilden yazdık
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieCategory> MovieCategories { get; set; }
        public DbSet<MovieSubCategory> MovieSubCategories { get; set; }

        //Bağlantı ayarlarımızı gerçekleştirdik
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //optionsBuilder.UseSqlServer("Server=DESKTOP-BUSD2NI\\SQLEXPRESS01;Database=FilmOneriDB;Integrated Security=True;TrustServerCertificate=True;");
            // optionsBuilder.UseSqlServer("Server=DESKTOP-CRN4JL7;Database=FilmRecommendDB;Trusted_Connection=True;TrustServerCertificate=True");
            optionsBuilder.UseSqlServer("Server=localhost;Database=FilmRecommendDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        //Fluent API ayarlarımızı gerçekleştirdik
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieCategory>()
                .HasMany(c => c.SubCategories)
                .WithOne(sc => sc.Category)
                .HasForeignKey(sc => sc.MovieCategoryID);

            modelBuilder.Entity<MovieSubCategory>()
                .HasMany(sc => sc.Movies)
                .WithOne(m => m.SubCategory)
                .HasForeignKey(m => m.MovieSubCategoryID);
        }

    }


   
   





    

}


