class Account
{
    public string Name { get; }
    public bool Active { get; }
    public string Role { get; }

    public Account(string name, bool active, string role)
    {
        Name = name;
        Active = active;
        Role = role;
    }
}