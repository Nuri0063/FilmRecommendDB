using FilmRecommend.Business;
using FilmRecommend.Data;

namespace FilmÖneriDB_
{
    public class Program
    {
        static void Main(string[] args)
        {

            DataOperations dataOperations = new();
            dataOperations.AddMoviesToDatabase();
            Console.WriteLine("Welcome to FilmRecommendApp");


            //FilmMoodDBContext context = new FilmMoodDBContext();
            //var a = context.MovieCategories.Find(1006);
            //context.MovieCategories.Remove(a);
            //context.SaveChanges();  





        }
    }
}