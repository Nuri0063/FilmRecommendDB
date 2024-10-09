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


    //Veri tabanına ekleme,silme,güncelleme işlemlerini gerçekleştireceğimiz class
    public class DataOperations
    {
        Methods methods = new();
        
        FilmMoodDBContext context = new();


        //Veritabanına değişikliklerin kayıt edildiği metod
       

        MovieCategory movieCategory = new()
        {
            CategoryName = "Aksiyon",
            SubCategories = new List<MovieSubCategory>()
    {
        new MovieSubCategory()
        {
            SubCategoryName = "Casusuluk",

            Movies = new HashSet<Movie>()
            {
                new Movie(){MovieName="Skyfall", ReleaseYear=2012, Director="Sam Mendes", LeadingActor="Daniel Craig", Rating=7.8},
                new Movie(){MovieName="Mission: Impossible - Fallout", ReleaseYear=2018, Director="Christopher McQuarrie", LeadingActor="Tom Cruise", Rating=7.7},
                new Movie(){MovieName="Tinker Tailor Soldier Spy", ReleaseYear=2011, Director="Tomas Alfredson", LeadingActor="Gary Oldman", Rating=7.1},
                new Movie(){MovieName="The Bourne Identity", ReleaseYear=2002, Director="Doug Liman", LeadingActor="Matt Damon", Rating=7.9},
                new Movie(){MovieName="Bridge of Spies", ReleaseYear=2015, Director="Steven Spielberg", LeadingActor="Tom Hanks", Rating=7.6}
            }
        }
    }
        };
      
        
        
        
        

       
    }
   





    public class Methods
    {
        //Veritabanına değişikliklerin kayıt edildiği metod
        public void AddMoviesToDatabase(MovieCategory movieCategory)
        {
            FilmMoodDBContext context = new();
            // context nesnesi ile MovieCategory'yi veritabanına ekliyoruz
            context.MovieCategories.Add(movieCategory);

            // Değişiklikleri veritabanına kaydediyoruz
            context.SaveChangesAsync();
        }
    }


}


