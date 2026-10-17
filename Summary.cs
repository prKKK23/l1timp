static class Summary
{
    public static string Build(Account[] items)
    {
        int count = 0;
        foreach (var item in items)
        {
            if (item.Role == "admin")
            {
                count++;
            }
        }
        return "AdminCount: " + count;
    }
}