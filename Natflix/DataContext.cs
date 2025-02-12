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
                new User("Elxan", "1234", UserType.User),
                new User("Ali", "1234", UserType.User)
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
            DataContext.Movies.Add(movie);
        }






    }
}
