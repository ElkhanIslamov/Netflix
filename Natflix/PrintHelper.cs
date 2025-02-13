
namespace Netflix
{
    public class PrintHelper
    {
        internal static void PrintMovies(List<Movie> movies)
        {
            Console.WriteLine(new string('-', 80));
            Console.WriteLine($"{"Id",-5}{"Name",-30}{"TimeOfSession",-20} {"Genre",-20}");
            Console.WriteLine(new string('-', 80));

            foreach (Movie movie in movies)
            {
                if (movie == null) continue;

                if (movie.Name == "Undefined") continue;

                Console.WriteLine($"{movie.Id,-5}{movie.Name,-30}{movie.TimeOfSession,-20}{movie.Genre.Name,-20}");
            }

            Console.WriteLine(new string('-', 80));
        }
        internal static void PrintGenre(List<Genre> genres)
        {
            Console.WriteLine(new string('-', 80));
            foreach (Genre genre in genres )
            {
                if (genre == null) continue;

                if (genre.Name == "Undefined") continue;
                Console.WriteLine($"{genre.Id,-5} {genre.Name,-10}");
            }
            Console.WriteLine(new string('-', 80));
        }
       


    }
}
