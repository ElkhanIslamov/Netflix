namespace Netflix;

internal class Movie:BaseModel
{
    public static int _id;

    public Movie(string name, string description, double timeOfSession, Genre genre, string country, int realiseYear, int rating)
    {
        Id = ++_id;
        Name = name;
        Description = description;
        TimeOfSession = timeOfSession;
        Genre = genre;
        Country = country;
        RealiseYear = realiseYear;
        Rating = rating;
    }
    public string Name { get; set; }
    public string Description { get; set; }
    public double TimeOfSession { get; set; }
    public int Rating { get; set; }
    public int RealiseYear { get; set; }
    public string Country { get; set; }
    public Genre Genre { get; set; }
}
