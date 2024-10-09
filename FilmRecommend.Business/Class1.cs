namespace FilmRecommend.Business
{
    using FilmRecommend.Data;
    using FilmRecommend.Entities;
    using System.Xml;

    public class DataOperations
    {
        FilmMoodDBContext context = new FilmMoodDBContext();

        // Filmleri ekleyen metot
        public void AddMoviesToDatabase()
        {
            /*
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
            */


            MovieCategory movieCategory = new()
            {
                CategoryName = "Aksiyon",
                SubCategories = new List<MovieSubCategory>()
            {

                 new MovieSubCategory()
                {
                    SubCategoryName = "Aksiyon",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Die Hard",
                            ReleaseYear=1988,
                            Director="John McTiernan",
                            LeadingActor="Bruce Wills",
                            Rating=8.2},

                        new Movie(){
                            MovieName="Mad Max: Fury Road",
                            ReleaseYear=2015,
                            Director="George Miller",
                            LeadingActor="Tom Hardy",
                            Rating=8.1},

                        new Movie(){
                            MovieName="John Wick",
                            ReleaseYear=2014,
                            Director="Chad Stahelski",
                            LeadingActor="Keanu Reeves",
                            Rating=7.4},

                        new Movie(){
                            MovieName="Judgment Day",
                            ReleaseYear=1991,
                            Director="James Cameron",
                            LeadingActor="Arnold Schwarzenegger"
                            , Rating=8.5},

                        new Movie(){
                            MovieName="The Dark Night",
                            ReleaseYear=2018,
                            Director="Christopher Nolan",
                            LeadingActor="Christian Bale",
                            Rating=9.0
                        }
                    }
                    },

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
                },

                    new MovieSubCategory()
                {
                    SubCategoryName = "Dövüş",
                    Movies = new HashSet<Movie>()
                    {
                        new Movie(){MovieName="Enter the Dragon", ReleaseYear=1973, Director="Robert Clouse", LeadingActor="Bruce Lee", Rating=7.6},
                        new Movie(){MovieName="The Raid:Redemption", ReleaseYear=2011, Director="Gareth Evans", LeadingActor="Iko Uwaise", Rating=7.6},
                        new Movie(){MovieName="Rocky", ReleaseYear=1976, Director="John G.Avildsen", LeadingActor="Sylvester Stallone", Rating=8.1},
                        new Movie(){MovieName="Ip Man", ReleaseYear=2008, Director="Wilson Yip", LeadingActor="Donnie Yen", Rating=8.0},
                        new Movie(){MovieName="Fight Clup", ReleaseYear=199, Director="David Fincher", LeadingActor="Tyler Durden", Rating=8.8}
                    }
                },

                        new MovieSubCategory()
                {
                    SubCategoryName = "Felaket",
                    Movies = new HashSet<Movie>()
                    {
                        new Movie(){MovieName="Twister", ReleaseYear=1996, Director="Jan de Bont", LeadingActor="Helen Hunt", Rating=6.4},
                        new Movie(){MovieName="Armageddon", ReleaseYear=1998, Director="Micheal Bay", LeadingActor="Bruce Wills", Rating=6.7},
                        new Movie(){MovieName="The Day After Tomorrow", ReleaseYear=2004, Director="Roland Emmerich", LeadingActor="Dennis Quaid", Rating=6.5},
                        new Movie(){MovieName="San Andreas", ReleaseYear=2015, Director="Brad Peyton", LeadingActor="Dwayne Johnson", Rating=6.1},
                        new Movie(){MovieName="2012", ReleaseYear=2009, Director="Roland Emmerich", LeadingActor="John Cusack", Rating=5.8}
                    }
                },

                            new MovieSubCategory()
                {
                    SubCategoryName = "Süper Kahraman",
                    Movies = new HashSet<Movie>()
                    {
                        new Movie(){MovieName="The Avengers", ReleaseYear=2012, Director="Joss Whedon", LeadingActor="Robert Downey Jr.", Rating=8.0},
                        new Movie(){MovieName="Spider-Man", ReleaseYear=2002, Director="Sam Raimi", LeadingActor="Tobet Maguire", Rating=7.4},
                        new Movie(){MovieName="Black Panther", ReleaseYear=2018, Director="Ryan Coogler", LeadingActor="Chadwick Boseman", Rating=7.3},
                        new Movie(){MovieName="Iron Man", ReleaseYear=2008, Director="Jon Favreau", LeadingActor="Robert Downey Jr.", Rating=7.9},
                        new Movie(){MovieName="Wonder Woman", ReleaseYear=2017, Director="Patty Jenkins", LeadingActor="Gal Gadot", Rating=7.4}
                    }
                }













                }

            };

            

            context.MovieCategories.Add(movieCategory); // Film kategorisini ekle
            context.SaveChanges(); // Değişiklikleri kaydet


        }












    }
}
    

