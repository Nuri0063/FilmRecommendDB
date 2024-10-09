namespace FilmRecommend.Business
{
    using FilmRecommend.Data;
    using FilmRecommend.Entities;

    public class DataOperations
    {
        FilmMoodDBContext context = new FilmMoodDBContext();

        // Filmleri ekleyen metot
        public void AddMoviesToDatabase()
        {
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

            context.MovieCategories.Add(movieCategory); // Film kategorisini ekle
            context.SaveChanges(); // Değişiklikleri kaydet
        }
    }

}
