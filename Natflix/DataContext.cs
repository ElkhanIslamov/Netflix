namespace Netflix
{
    internal class DataContext
    {
        public DataContext()
        {
            Users = new List<User>();
            Users[0] = new User(,);
            Genres = new List<Genre>();

            Genres[0] = new Genre("Drama");
            Genres[1] = new Genre("Comedy");
            Genres[2] = new Genre("Criminal");
            Genres[3] = new Genre("Action");
            Genres[4] = new Genre("Horror");

            Movies = new List<Movie>();

            Movies[0] = new Movie("Titanik","Film about Ship", 2.2 , Genres[0],"USA",1997,7);
            Movies[1] = new Movie("Ted", "Film about teddy bear", 1.5 , Genres[1],"Italia",2000,15);
            Movies[2] = new Movie("Leon: The Professional", "Film abouta professional assassin", 1.5, Genres[2],"France",2020,16);
            Movies[3] = new Movie("Venom", "Eddie Brock and Venom must make a devastating decision", 1.55 , Genres[3],"Norway",1995,25);
            Movies[4] = new Movie("World War Z", "Film about a zombie", 1.56 , Genres[4],"Germany",1999,12);

            Movies[5] = new Movie("Arshin mal alan", "Film about a man", 1.45, Genres[0],"Azerbaycan",1955,15);
            Movies[6] = new Movie("Table", "Film about tabel", 2.5, Genres[1],"Uzabekistan",1966,12);
            Movies[7] = new Movie("Rabbit in house", "Film about killer", 1.56, Genres[2],"Russian",1992,12);
            Movies[8] = new Movie("Cat and Dog", "Cat fight with dog", 1.32, Genres[3],"Korea", 2002,12);
            Movies[9] = new Movie("Car crash", "Film about a mercedes", 1.33, Genres[4],"China",1959,15);

            Movies[10] = new Movie("Take me out", "Film about a class", 1.52, Genres[0], "Canada", 1989, 19);
            Movies[11] = new Movie("What are you doing", "About a man who lived in Baki", 2.5, Genres[1], "Georgia", 1972, 11);
            Movies[12] = new Movie("Call me John", "Film about John", 1.36, Genres[2], "Turkiye", 1981, 22);
            Movies[13] = new Movie("See you soon", "About glass", 1.42, Genres[3], "Iran", 2012, 5);
            Movies[14] = new Movie("Photo of my face", "Film about a phot", 1.41, Genres[4], "Moldova", 1996, 17);




        }
        public void AddMovie(Movie movie)
        {
            DataContext.Movies.Add(movie);
            Console.WriteLine("Movie Added");

        }
        public void AddGenre(Genre genre)
        {
            DataContext.Genres.Add(genre);
            Console.WriteLine("Genre Added");
        }
        public void AddUser(User user)
        {
            DataContext.Users.Add(user);
            Console.WriteLine("User Added");
        }

        public static List<Movie> Movies { get; set; } = new();
        public static List<Genre> Genres { get; set; } = new();
        public static List<User> Users { get; set; } = new();






        
    }
}
