namespace Netflix;

internal class Admin
{
    public Admin()
    {
        
    }
    public Admin(string name, string password, UserType type)
    {
        Name = name;
        Password = password;
        Type = type;
    }

    public UserType Type { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }

}
