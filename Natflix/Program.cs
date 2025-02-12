using System.Security.Cryptography.X509Certificates;
using static System.Formats.Asn1.AsnWriter;

namespace Netflix;
internal class Program
{
    static void Main(string[] args)
    {
        var dataContext = new DataContext();
        string username, password;
        Admin   admin;
        do
        {
            Console.Write("Username:");
            username = Console.ReadLine();
            Console.Write("Password:");
            password = Console.ReadLine();
            admin = dataContext.GetAdmin(username, password);
        } while (username=="Undefined");

        Console.WriteLine("Add Movie");
      List<Movie> list = new List<Movie>();
        var movie = new Movie() {}
        
        

        //Console.WriteLine($"List of movies:");
        //PrintHelper.PrintMovies(DataContext.Movies);

        



    }
}
