static class Formatter
{
    public static string Format(Account item)
    {
        return item.Name + "; role=" + item.Role;
    }
}