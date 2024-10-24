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
          

            // Akiyon kategorisi altındaki alt başlıkları ve o alt başlıklara ait filmleri ekleme 
            MovieCategory movieCategoryAksiyon = new() 
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

            // Belgesel kategorisi altındaki alt başlıkları ve o alt başlıklara ait filmleri ekleme 
            MovieCategory movieCategoryBelgesel = new()
            {
                CategoryName = "Belgesel",
                SubCategories = new List<MovieSubCategory>()
            {

                new MovieSubCategory()
                {
                    SubCategoryName = "Belgesel",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Planet Earth",
                            ReleaseYear=2006,
                            Director="Alastair Fothergill",
                            LeadingActor="David Attenborough",
                            Rating=9.4},

                        new Movie(){
                            MovieName="The Last Dance",
                            ReleaseYear=2020,
                            Director="Jason Hehir",
                            LeadingActor="Michael Jordan",
                            Rating=9.1},

                        new Movie(){
                            MovieName="Free Solo",
                            ReleaseYear=2018,
                            Director="Elizabeth Chai Vasarhelyi, Jimmy Chin",
                            LeadingActor="Alex Honnold",
                            Rating=8.1},

                        new Movie(){
                            MovieName="13th ",
                            ReleaseYear=2016,
                            Director="Ava DuVernay",
                            LeadingActor="Belgesel"
                            , Rating=8.2},

                        new Movie(){
                            MovieName="Won't You Be My Neighbor?",
                            ReleaseYear=2018,
                            Director="Morgan Neville",
                            LeadingActor="Fred Rogers",
                            Rating=8.4
                        }
                    }

                 },

                new MovieSubCategory()
                {
                    SubCategoryName = "Doğa",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="March of the Penguins",
                            ReleaseYear=2005,
                            Director="Luc Jacquet",
                            LeadingActor="Morgan Freeman",
                            Rating=7.5},

                        new Movie(){
                            MovieName="Rivers and Tides",
                            ReleaseYear=2001,
                            Director="Thomas Riedelsheimer",
                            LeadingActor="Andy Goldsworthy",
                            Rating=8.1},

                        new Movie(){
                            MovieName="The Blue Planet",
                            ReleaseYear=2001,
                            Director="Alastair Fothergill, Andy Byatt",
                            LeadingActor="David Attenborough",
                            Rating=9.0},

                        new Movie(){
                            MovieName="Chasing Ice",
                            ReleaseYear=2012,
                            Director="Jeff Orlowski",
                            LeadingActor=" James Balog"
                            , Rating=7.8},

                        new Movie(){
                            MovieName="Our Planet",
                            ReleaseYear=2019,
                            Director="Alastair Fothergill, Jonathan Hughes",
                            LeadingActor="David Attenborough",
                            Rating=9.3
                        }
                    }
                },

                new MovieSubCategory()
                {
                    SubCategoryName = "Gezi", //yarım
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="March of the Penguins",
                            ReleaseYear=2005,
                            Director="Luc Jacquet",
                            LeadingActor="Morgan Freeman",
                            Rating=7.5},

                        new Movie(){
                            MovieName="Rivers and Tides",
                            ReleaseYear=2001,
                            Director="Thomas Riedelsheimer",
                            LeadingActor="Andy Goldsworthy",
                            Rating=8.1},

                        new Movie(){
                            MovieName="The Blue Planet",
                            ReleaseYear=2001,
                            Director="Alastair Fothergill, Andy Byatt",
                            LeadingActor="David Attenborough",
                            Rating=9.0},

                        new Movie(){
                            MovieName="Chasing Ice",
                            ReleaseYear=2012,
                            Director="Jeff Orlowski",
                            LeadingActor=" James Balog"
                            , Rating=7.8},

                        new Movie(){
                            MovieName="Our Planet",
                            ReleaseYear=2019,
                            Director="Alastair Fothergill, Jonathan Hughes",
                            LeadingActor="David Attenborough",
                            Rating=9.3
                        }
                    }
                },

                new MovieSubCategory()
                {
                    SubCategoryName = "Yarı Belgesel",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="March of the Penguins",
                            ReleaseYear=2005,
                            Director="Luc Jacquet",
                            LeadingActor="Morgan Freeman",
                            Rating=7.5},

                        new Movie(){
                            MovieName="Rivers and Tides",
                            ReleaseYear=2001,
                            Director="Thomas Riedelsheimer",
                            LeadingActor="Andy Goldsworthy",
                            Rating=8.1},

                        new Movie(){
                            MovieName="The Blue Planet",
                            ReleaseYear=2001,
                            Director="Alastair Fothergill, Andy Byatt",
                            LeadingActor="David Attenborough",
                            Rating=9.0},

                        new Movie(){
                            MovieName="Chasing Ice",
                            ReleaseYear=2012,
                            Director="Jeff Orlowski",
                            LeadingActor=" James Balog"
                            , Rating=7.8},

                        new Movie(){
                            MovieName="Our Planet",
                            ReleaseYear=2019,
                            Director="Alastair Fothergill, Jonathan Hughes",
                            LeadingActor="David Attenborough",
                            Rating=9.3
                        }
                    }
                },


            }


                };

            // BilimKurgu kategorisi altındaki alt başlıkları ve o alt başlıklara ait filmleri ekleme 
            MovieCategory movieCategoryBilimkurgu = new()
            {
                CategoryName = "Bilimkurgu ",
                SubCategories = new List<MovieSubCategory>()
            {

                new MovieSubCategory()
                {
                    SubCategoryName = "Bilimkurgu",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Blade Runner 2049 ",
                            ReleaseYear=2017,
                            Director="Denis Villeneuve",
                            LeadingActor=" Ryan Gosling",
                            Rating=8.0},

                        new Movie(){
                            MovieName="The Matrix",
                            ReleaseYear=1999,
                            Director="Lana Wachowski",
                            LeadingActor="Keanu Reeves",
                            Rating=8.7},

                        new Movie(){
                            MovieName="Interstellar ",
                            ReleaseYear=2014,
                            Director="Christopher Nolan",
                            LeadingActor="Matthew McConaughey",
                            Rating=8.6},

                        new Movie(){
                            MovieName="Inception ",
                            ReleaseYear=2010,
                            Director="Christopher Nolan",
                            LeadingActor="Leonardo DiCaprio"
                            , Rating=8.8},

                        new Movie(){
                            MovieName="Minority Report",
                            ReleaseYear=2002,
                            Director="Steven Spielberg",
                            LeadingActor="Tom Cruise",
                            Rating=7.7
                        }
                    }
                },

                new MovieSubCategory()
                {
                    SubCategoryName = "Alternatif Tarih",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="The Man in the High Castle",
                            ReleaseYear=2015,
                            Director="Frank Spotnitz",
                            LeadingActor="Alexa Davalos",
                            Rating=8.0},

                        new Movie(){
                            MovieName="The Plot Against America",
                            ReleaseYear=2020,
                            Director="David Simon",
                            LeadingActor="Winona Ryder",
                            Rating=7.3},

                        new Movie(){
                            MovieName="V for Vendetta",
                            ReleaseYear=2005,
                            Director="James McTeigue",
                            LeadingActor="Hugo Weaving",
                            Rating=8.1},

                        new Movie(){
                            MovieName="The Butterfly Effect",
                            ReleaseYear=2004,
                            Director="Eric Bress",
                            LeadingActor="Ashton Kutcher"
                            , Rating=7.6},

                        new Movie(){
                            MovieName="Fatherland",
                            ReleaseYear=1994,
                            Director="Christopher Menaul",
                            LeadingActor="Rutger Hauer",
                            Rating=6.4}

                    }
                 },

                new MovieSubCategory()
                {
                    SubCategoryName = "Askerî Bilimkurgu",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Starship Troopers",
                            ReleaseYear=1997,
                            Director="Paul Verhoeven",
                            LeadingActor="Casper Van Dien",
                            Rating=7.3},

                        new Movie(){
                            MovieName="Edge of Tomorrow",
                            ReleaseYear=2014,
                            Director="Doug Liman",
                            LeadingActor="Tom Cruise",
                            Rating=7.9},

                        new Movie(){
                            MovieName="RoboCop",
                            ReleaseYear=1987,
                            Director="Paul Verhoeven",
                            LeadingActor="Peter Weller",
                            Rating=7.6},

                        new Movie(){
                            MovieName="Battle Los Angeles",
                            ReleaseYear=2011,
                            Director="Jonathan Liebesman",
                            LeadingActor="Aaron Eckhart"
                            , Rating=5.7},

                        new Movie(){
                            MovieName="Dredd ",
                            ReleaseYear=2012,
                            Director="Pete Travis",
                            LeadingActor="Karl Urban",
                            Rating=7.1}

                    }
                },

                new MovieSubCategory()
                {
                    SubCategoryName = "Bilimkurgu-Macera",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Guardians of the Galaxy",
                            ReleaseYear=2014,
                            Director="James Gunn",
                            LeadingActor="Chris Pratt",
                            Rating=8.0},

                        new Movie(){
                            MovieName="Star Wars: Episode IV - A New Hope",
                            ReleaseYear=1977,
                            Director="George Lucas",
                            LeadingActor="Mark Hamill",
                            Rating=8.6},

                        new Movie(){
                            MovieName="The Fifth Element",
                            ReleaseYear=1997,
                            Director="Luc Besson",
                            LeadingActor=" Bruce Willis",
                            Rating=7.7},

                        new Movie(){
                            MovieName="Avatar",
                            ReleaseYear=2009,
                            Director="James Cameron",
                            LeadingActor="Sam Worthington"
                            , Rating=7.9},

                        new Movie(){
                            MovieName="Jurassic Park",
                            ReleaseYear=1993,
                            Director="Steven Spielberg",
                            LeadingActor="Sam Neill",
                            Rating=8.2}

                    }
                },

                new MovieSubCategory()
                {
                    SubCategoryName = "Kıyamet Sonrası Bilimkurgu",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Mad Max: Fury Road",
                            ReleaseYear=2015,
                            Director="George Miller",
                            LeadingActor="Tom Hardy",
                            Rating=8.1},

                        new Movie(){
                            MovieName="Children of Men",
                            ReleaseYear=2006,
                            Director="Alfonso Cuarón",
                            LeadingActor="Clive Owen",
                            Rating=7.9},

                        new Movie(){
                            MovieName="The Road",
                            ReleaseYear=2009,
                            Director="John Hillcoat",
                            LeadingActor="Viggo Mortensen",
                            Rating=7.2},

                        new Movie(){
                            MovieName="Snowpiercer",
                            ReleaseYear=2013,
                            Director="Bong Joon Ho",
                            LeadingActor="Chris Evans"
                            , Rating=7.1},

                        new Movie(){
                            MovieName="I Am Legend",
                            ReleaseYear=2007,
                            Director="Francis Lawrence",
                            LeadingActor="Will Smith",
                            Rating=7.2}

                    }
                },

                }

            };

            // Dram kategorisi altındaki alt başlıkları ve o alt başlıklara ait filmleri ekleme
            MovieCategory movieCategoryDram = new()
            {
                CategoryName = "Dram",
                SubCategories = new List<MovieSubCategory>()
            {

                new MovieSubCategory()
                {
                    SubCategoryName = "Dramatik",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="The Shawshank Redemption",
                            ReleaseYear=1994,
                            Director="Frank Darabont",
                            LeadingActor="Tim Robbins, Morgan Freeman",
                            Rating=9.3},

                        new Movie(){
                            MovieName="Forrest Gump",
                            ReleaseYear=1994,
                            Director="Robert Zemeckis",
                            LeadingActor="Tom Hanks",
                            Rating=8.8},

                        new Movie(){
                            MovieName="The Green Mile",
                            ReleaseYear=1999,
                            Director="Frank Darabont",
                            LeadingActor="Tom Hanks, Michael Clarke Duncan",
                            Rating=8.6},

                        new Movie(){
                            MovieName="A Beautiful Mind",
                            ReleaseYear=2001,
                            Director="Ron Howard",
                            LeadingActor="Russell Crowe"
                            , Rating=8.2},

                        new Movie(){
                            MovieName="12 Years a Slave",
                            ReleaseYear=2013,
                            Director="Steve McQueen",
                            LeadingActor="Chiwetel Ejiofor",
                            Rating=8.1
                        }
                    }
                },

                new MovieSubCategory()
                {
                    SubCategoryName = "Melodram",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Far from the Madding Crowd",
                            ReleaseYear=2015,
                            Director="Thomas Vinterberg",
                            LeadingActor="Carey Mulligan",
                            Rating=7.1},

                        new Movie(){
                            MovieName="Atonement ",
                            ReleaseYear=2007,
                            Director="Joe Wright",
                            LeadingActor=" Keira Knightley",
                            Rating=7.8},

                        new Movie(){
                            MovieName="Revolutionary Road",
                            ReleaseYear=2008,
                            Director="Sam Mendes",
                            LeadingActor="Leonardo DiCaprio",
                            Rating=7.3},

                        new Movie(){
                            MovieName="Titanic ",
                            ReleaseYear=1997,
                            Director="James Cameron",
                            LeadingActor="Leonardo DiCaprio, Kate Winslet"
                            , Rating=7.9},

                        new Movie(){
                            MovieName="The Notebook",
                            ReleaseYear=2004,
                            Director="Nick Cassavetes",
                            LeadingActor=" Ryan Gosling",
                            Rating=7.8
                        }
                    }
                },

                new MovieSubCategory()
                {
                    SubCategoryName = "Politik Dram",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="The Trial of the Chicago 7",
                            ReleaseYear=2020,
                            Director="Aaron Sorkin",
                            LeadingActor="Eddie Redmayne",
                            Rating=7.8},

                        new Movie(){
                            MovieName="The Post",
                            ReleaseYear=2017,
                            Director="Steven Spielberg",
                            LeadingActor="Meryl Streep",
                            Rating=7.2},

                        new Movie(){
                            MovieName="Milk ",
                            ReleaseYear=2008,
                            Director="Gus Van Sant",
                            LeadingActor="Sean Penn",
                            Rating=7.5},

                        new Movie(){
                            MovieName="Lincoln ",
                            ReleaseYear=2012,
                            Director="Steven Spielberg",
                            LeadingActor="Daniel Day-Lewis"
                            , Rating=7.3},

                        new Movie(){
                            MovieName="The Ides of March",
                            ReleaseYear=2011,
                            Director="George Clooney",
                            LeadingActor="Ryan Gosling",
                            Rating=7.1
                        }
                    }
                },

                new MovieSubCategory()
                {
                    SubCategoryName = "Tarihi Dram",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Dunkirk ",
                            ReleaseYear=2017,
                            Director="Christopher Nolan",
                            LeadingActor=" Fionn Whitehead",
                            Rating=7.8},

                        new Movie(){
                            MovieName="The Last Emperor",
                            ReleaseYear=1987,
                            Director="Bernardo Bertolucci",
                            LeadingActor="John Lone",
                            Rating=7.7},

                        new Movie(){
                            MovieName="The King's Speech",
                            ReleaseYear=2010,
                            Director="Tom Hooper",
                            LeadingActor="Colin Firth",
                            Rating=8.0},

                        new Movie(){
                            MovieName="Gladiator ",
                            ReleaseYear=2000,
                            Director="Ridley Scott",
                            LeadingActor="Russell Crowe, Joaquin Phoenix"
                            , Rating=8.5},

                        new Movie(){
                            MovieName="Schindler's List",
                            ReleaseYear=1993,
                            Director="Steven Spielberg",
                            LeadingActor="Liam Neeson",
                            Rating=9.0
                        }
                    }
                },

                }
            };

            // Gerilim kategorisi altındaki alt başlıkları ve o alt başlıklara ait filmleri ekleme
            MovieCategory movieCategoryGerilim = new()
            {
                CategoryName = "Gerilim",
                SubCategories = new List<MovieSubCategory>()
            {

                new MovieSubCategory()
                {
                    SubCategoryName = "Gerilim ",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Shutter Island",
                            ReleaseYear=2010,
                            Director="Martin Scorsese",
                            LeadingActor="Leonardo DiCaprio",
                            Rating=8.2},

                        new Movie(){
                            MovieName="Zodiac",
                            ReleaseYear=2007,
                            Director="David Fincher",
                            LeadingActor="Jake Gyllenhaal, Robert Downey Jr.",
                            Rating=7.7},

                        new Movie(){
                            MovieName="The Silence of the Lambs",
                            ReleaseYear=1991,
                            Director="Jonathan Demme",
                            LeadingActor="Jodie Foster",
                            Rating=8.6},

                        new Movie(){
                            MovieName="Gone Girl",
                            ReleaseYear=2014,
                            Director="David Fincher",
                            LeadingActor="Ben Affleck"
                            , Rating=8.1},

                        new Movie(){
                            MovieName="Se7en ",
                            ReleaseYear=1995,
                            Director="David Fincher",
                            LeadingActor="Brad Pitt, Morgan Freeman",
                            Rating=8.6
                        }
                    }
                },

                new MovieSubCategory()
                {
                    SubCategoryName = "Aksiyon-Gerilim",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Colombiana",
                            ReleaseYear=2011,
                            Director="Olivier Megaton",
                            LeadingActor="Zoe Saldana",
                            Rating=6.4},

                        new Movie(){
                            MovieName="Casino Royale",
                            ReleaseYear=2006,
                            Director="Martin Campbell",
                            LeadingActor="Daniel Craig",
                            Rating=8.0},

                        new Movie(){
                            MovieName="John Wick: Chapter 2",
                            ReleaseYear=2017,
                            Director="Chad Stahelski",
                            LeadingActor=" Keanu Reeves",
                            Rating=7.4},

                        new Movie(){
                            MovieName="The Dark Knight Rises",
                            ReleaseYear=2012,
                            Director="Christopher Nolan",
                            LeadingActor="Christian Bale, Tom Hardy"
                            , Rating=8.4},

                        new Movie(){
                            MovieName="Mad Max: Fury Road ",
                            ReleaseYear=2015,
                            Director="George Miller",
                            LeadingActor="Tom Hardy",
                            Rating=8.1
                        }
                    }
                },
                
                new MovieSubCategory()
                {
                    SubCategoryName = "Politik Gerilim",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="Argo",
                            ReleaseYear=2012,
                            Director=" Ben Affleck",
                            LeadingActor="Ben Affleck",
                            Rating=7.7},

                        new Movie(){
                            MovieName="The Manchurian Candidate",
                            ReleaseYear=2004,
                            Director="Jonathan Demme",
                            LeadingActor="Denzel Washington",
                            Rating=6.6},

                        new Movie(){
                            MovieName="Clear and Present Danger",
                            ReleaseYear=1994,
                            Director="Phillip Noyce",
                            LeadingActor="Harrison Ford",
                            Rating=6.9},

                        new Movie(){
                            MovieName="Body of Lies",
                            ReleaseYear=2008,
                            Director="Ridley Scott",
                            LeadingActor=" Leonardo DiCaprio"
                            , Rating=7.0},

                        new Movie(){
                            MovieName="The Hunt for Red October",
                            ReleaseYear=1990,
                            Director="John McTiernan",
                            LeadingActor="Sean Connery",
                            Rating=7.5
                        }
                    }
                },

                new MovieSubCategory()
                {
                    SubCategoryName = "Psikolojik Gerilim",
                    Movies = new HashSet<Movie>()
                    {

                        new Movie(){
                            MovieName="The Sixth Sense ",
                            ReleaseYear=1999,
                            Director="M. Night Shyamalan",
                            LeadingActor="Bruce Willis",
                            Rating=8.2},

                        new Movie(){
                            MovieName="Memento",
                            ReleaseYear=2000,
                            Director="Christopher Nolan",
                            LeadingActor="Guy Pearce",
                            Rating=8.4},

                        new Movie(){
                            MovieName="Gone Girl",
                            ReleaseYear=2014,
                            Director="David Fincher",
                            LeadingActor="Ben Affleck",
                            Rating=8.1},

                        new Movie(){
                            MovieName="Fight Clup",
                            ReleaseYear=1999,
                            Director="David Fincher",
                            LeadingActor="Brad Pitt"
                            , Rating=8.8},

                        new Movie(){
                            MovieName="Black Swan",
                            ReleaseYear=2010,
                            Director="Darren Aronofsky",
                            LeadingActor="Natalie Portman",
                            Rating=8.0
                        }
                    }
                },

                }
            };












            context.MovieCategories.Add(movieCategoryGerilim); // Film kategorisini ekle
            context.SaveChanges(); // Değişiklikleri kaydet


        }

      











    }
}
    

