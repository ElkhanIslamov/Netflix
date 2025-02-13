using System.Data;
using System.Security.Cryptography.X509Certificates;
using static System.Formats.Asn1.AsnWriter;

namespace Netflix;
internal class Program
{
    static void Main(string[] args)
    {
        var dataContext = new DataContext();
        string username, password;
        User user;
        do
        {

            Console.Write("Username:");
            username = Console.ReadLine();

            Console.Write("Password:");
            password = Console.ReadLine();

            user = dataContext.GetUser(username, password);


            Console.WriteLine($" Welcome {username} to Netflix");
            dataContext.WatchMovie();

            Console.Write("Enter movie id:");
            int id = int.Parse(Console.ReadLine());

            var movie = dataContext.GetMovie(id);
            Console.WriteLine($"{movie.Name}");

            Console.WriteLine(new string('-', 80));

            Console.Write("Enter command - genre - for filter genre: ");
            string command = Console.ReadLine();
            if (command == "genre")
            {
                dataContext.FilterMovie();
            }

            Console.Write("Enter name of film  for searching movie: ");
            string search = Console.ReadLine();
            if (movie.Name == search)
            {
                dataContext.SearchMovie(search);
            }
            //if (movie.Name == "Undefined") return;
        } while (user.Name == "Undefined");
        if (user.IsAdmin)
        {

            Console.WriteLine("Add Movie");
            string add = Console.ReadLine();
            //dataContext.AddMovie()



            Console.WriteLine($"List of movies:");
            PrintHelper.PrintMovies(DataContext.Movies);





        }
    }
}
