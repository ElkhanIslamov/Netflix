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
            dataContext.WatchMovie();

            Console.Write("Enter movie id:");
            int id = int.Parse(Console.ReadLine());

            var movie = dataContext.GetMovie(id);
            Console.WriteLine($"{movie.Name}");

            if (movie.Name == "Undefined") return;

            string command = Console.ReadLine();
            if(command=="genre")
            {
                Console.WriteLine("Choose genre from list");
                PrintHelper.PrintGenre(movie.Genre.Name);
            }

        } while (user.Name=="Undefined");

        //if (user.IsAdmin)
        //{
        //    var admin = dataContext.GetAdmin(username,password);
        //    Console.WriteLine($"Welcome {admin.Name}");

            //var store = dataContext.GetStore(seller.StoreId);

            //Console.WriteLine($"Store name:{store.Name}");
            //PrintHelper.PrintProducts(store.Products);

            //Console.WriteLine("Choose command,[add, remove]");

            //string command = Console.ReadLine();

            //if (command == "add")
            //{
            //    Console.Write("Enter the name:");
            //    string name = Console.ReadLine();
            //    Console.Write("Enter the price:");
            //    decimal price = decimal.Parse(Console.ReadLine());

            //    var product = new Product(name, price);
            //    var products = new Product[store.Products.Length + 1];
            //    products = [.. store.Products, product];
            //    //for (int i = 0; i< store.Products.Length; i++)
            //    //{
            //    //    products[i] = store.Products[i];
            //    //}
            //    //products[products.Length - 1] = product;
            //    store.Products = products;
            //    PrintHelper.PrintProducts(store.Products);
           // }

            //Console.WriteLine("Add Movie");
            //List<Movie> list = new List<Movie>();
            //var movie = new Movie() { }



            //Console.WriteLine($"List of movies:");
            //PrintHelper.PrintMovies(DataContext.Movies);





        }
}
