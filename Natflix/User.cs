﻿namespace Netflix;

internal class User:BaseModel
{
    internal static int _id;
    public User()
    {
        
    }
    public User(string name, string password, UserType type)
    {
        Id = ++_id;
        Name = name;
        Password = password;
        Type = type;
    }

    public UserType Type { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public bool IsAdmin { get; set; }
}
