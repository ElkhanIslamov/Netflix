namespace Netflix;

public class Genre : BaseModel
{
    public static int _id;
    public Genre(string name)
    {
        Id = ++_id;
        Name = name;
    }
    public string Name { get; set; }
}
