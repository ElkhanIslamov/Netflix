
namespace Netflix
{
    public class PrintHelper
    {
        internal static void PrintMovies(List<Movie> movies)
        {
            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"{"Id",-5}{"Name",-10}{"TimeOfSession",-5} {"Genre",-10}");
            Console.WriteLine(new string('-', 50));

            foreach (Movie movie in movies)
            {
                if (movie == null) continue;

                if (movie.Name == "Undefined") continue;

                Console.WriteLine($"{movie.Id,-5}{movie.Name,-10}{movie.TimeOfSession,-5}{movie.Genre.Name,-10}");
            }

            Console.WriteLine(new string('-', 30));
        }

        internal static void PrintMovies(bool v)
        {
            throw new NotImplementedException();
        }
    }
}
