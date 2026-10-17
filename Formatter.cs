static class Formatter
{
    public static string Format(Account item)
    {
        return "ACTIVE: " + item.Name + "; role=" + item.Role;
    }
}