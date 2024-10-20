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
            //var a = context.MovieCategories.Find(1002);
            //var b = context.MovieCategories.Find(6);
            //context.Remove(a);
            //context.Remove(b);
            //context.SaveChanges();




        }
    }
}