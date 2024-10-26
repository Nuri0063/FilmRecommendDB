using FilmRecommend.Business;
using FilmRecommend.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using FilmRecommend.Entities;


namespace FilmÖneriDB_
{
    public class Program
    {
        static void Main(string[] args)
        {

            // FilmDbContext nesnesini oluşturuyoruz.
            using (FilmMoodDBContext context = new FilmMoodDBContext())
            {
                // Kategorileri alıyoruz.
                List<MovieCategory> categories = context.MovieCategories.ToList();

                // Kullanıcıdan bir kategori seçmesini istiyoruz.
                Console.WriteLine("Lütfen bir kategori seçin:");

                // Kategorileri ekrana yazdırıyoruz.
                for (int i = 0; i < categories.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + categories[i].CategoryName);
                    
                }
                Console.WriteLine();
                Console.Write("Seçiminiz:");
                

                // Kategori seçimi için kullanıcıdan giriş alıyoruz.
                int selectedCategoryIndex = Convert.ToInt32(Console.ReadLine()) - 1;

                // Seçilen kategoriyi alıyoruz.
                MovieCategory selectedCategory = categories[selectedCategoryIndex];

                // Seçilen Kategorinin Alt Kategorilerini Alıyoruz.
                List<MovieSubCategory> subCategories = context.MovieSubCategories
                    .Where(sc => sc.MovieCategoryID == selectedCategory.MovieCategoryID).ToList();

                // Alt kategorileri ekrana yazdırıyoruz.
                Console.WriteLine(selectedCategory.CategoryName + " kategorisine ait alt kategoriler:");
                for (int i = 0; i < subCategories.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + subCategories[i].SubCategoryName);
                }

                // Alt kategori seçimi için kullanıcıdan giriş alıyoruz.
                int selectedSubCategoryIndex = Convert.ToInt32(Console.ReadLine()) - 1;

                // Seçilen alt kategoriyi alıyoruz.
                MovieSubCategory selectedSubCategory = subCategories[selectedSubCategoryIndex];

                // Seçilen Alt Kategorinin Filmlerini Alıyoruz.
                List<Movie> movies = context.Movies
                    .Where(m => m.MovieSubCategoryID == selectedSubCategory.MovieSubCategoryID).ToList();

                // Filmleri ekrana yazdırıyoruz.
                Console.WriteLine(selectedSubCategory.SubCategoryName + " alt kategorisine ait filmler:");
                for (int i = 0; i < movies.Count; i++)
                {
                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine("Film Adı       : " + movies[i].MovieName);
                    Console.WriteLine("Yönetmen       : " + movies[i].Director);
                    Console.WriteLine("Çıkış Yılı     : " + movies[i].ReleaseYear);
                    Console.WriteLine("Başrol Oyuncu  : " + movies[i].LeadingActor);
                    Console.WriteLine("IMDB Puanı     : " + movies[i].Rating);
                    Console.WriteLine("---------------------------------------------------------\n");
                }
            }

                // Eğer film yoksa kullanıcıya bilgi veriyoruz.
                if (movies.Count == 0)
                {
                    Console.WriteLine("Bu alt kategoride film bulunmamaktadır.");
                }
            }

            // Programı sonlandırmak için kullanıcıdan bir tuşa basmasını istiyoruz.
            Console.WriteLine("Programı sonlandırmak için bir tuşa basın.");
            Console.ReadKey();
        }
    }
}