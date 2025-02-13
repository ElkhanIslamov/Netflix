namespace Netflix;
public class Movie:BaseModel
{
    public static int _id;
    public Movie(string name)
    {
        Name = name;
    }
    public Movie(string name,  double timeOfSession, Genre genre)
    {
        Id = ++_id;
        Name = name;
        TimeOfSession = timeOfSession;
        Genre = genre;
    }
    public string Name { get; set; }
    public double TimeOfSession { get; set; }
    public Genre Genre { get; set; }
}
