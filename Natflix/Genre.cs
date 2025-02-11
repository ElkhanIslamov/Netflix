namespace Natflix;

internal class Genre
{
    internal static int _id;
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Movie>? Movies { get; set; }

     
}
