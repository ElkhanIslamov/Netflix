using System.Threading.Channels;

namespace Netflix
{
    internal class DataContext
    {
        public DataContext()
        {
            Admins = 
            [
                new Admin("Ferid", "1234", UserType.Admin), 
                new Admin("Hasan", "1234",UserType.Admin)
            ];
            Users =
            [
                new User("Elxan", "1234", UserType.User,false),
                new User("Ali", "1234", UserType.User,false)
            ];
            Genres =
            [
                new Genre("Drama"),
                new Genre("Comedy"),
                new Genre("Criminal"),
                new Genre("Action"),
                new Genre("Horror")
            ];

            Movies =
            [
                new Movie("Titanik", 15,Genres[0]),
                new Movie("Ted",12, Genres[1]),
                new Movie("Leon: The Professional", 15, Genres[2]),
                new Movie("Venom", 9, Genres[3]),
                new Movie("World War Z", 10, Genres[4]),

                new Movie("Arshin mal alan", 7, Genres[0]),
                new Movie("Table", 13, Genres[1]),
                new Movie("Rabbit in house", 20, Genres[2]),
                new Movie("Cat and Dog", 17, Genres[3]),
                new Movie("Car crash", 23, Genres[4]),

                new Movie("Take me out", 55, Genres[0]),
                new Movie("What are you doing", 26, Genres[1]),
                new Movie("Call me John", 21, Genres[2]),
                new Movie("See you soon", 3, Genres[3]),
                new Movie("Photo of my face", 14, Genres[4])
            ];

        }
        public static List<Movie> Movies { get; set; } = [];
        public static List<Genre> Genres { get; set; } = [];
        public static List<User> Users { get; set; } = [];
        public static List<Admin> Admins { get; set; } = [];

        public User GetUser(string username, string password)
        {
            foreach (var item in Users)
            {
                if (username == item.Name && password == item.Password)
                    return item;
            }

            return new User() { Name = "Undefined" };
        }
        
        public Admin GetAdmin(string username, string password)
        {
            foreach (var item in Admins)
            {
                if (username == item.Name && password == item.Password)
                    return item;
            }

            return new Admin() { Name = "Undefined" };
        }
        public void AddMovie(Movie movie)
        {
            List<Movie> list = [];
            list.Add(movie);
            
        }
        public Movie GetMovie(int id)
        {
            foreach(var item in Movies)
            {
                if (item.Id == null) continue;
                if (item.Id == id) 
                return item;
             }
            return new Movie("Id-ni duzgun daxil edin");
        }
        public Movie GetMovieByGenre(string genre)
        {
            foreach (var item in Movies)
            {
                if (item.Genre == null) continue;
                if (item.Genre.Name == genre )
                    return item;
            }
            return new Movie("Id-ni duzgun daxil edin");
        }

        public void  WatchMovie()
        {
            Console.WriteLine(new string('-', 80));
            PrintHelper.PrintMovies(DataContext.Movies);
        }
        public void FilterMovie()
        {
            Console.WriteLine(new string('-', 80));
            Console.WriteLine($"{"Id",-5}{"Name",-30}");
            PrintHelper.PrintGenre(DataContext.Genres);
        }
        public Movie SearchMovie(string name)
        {
            
            foreach (var item in Movies)
            {
                if (item.Name == null) continue;
                if (item.Name == name)
                Console.WriteLine($"Filmin adi {item.Name}");
                    
            }
            Console.WriteLine("Xosh izlemeler");
            return new Movie("Filmin adini duzgun daxil edin");
        }




    }
}
