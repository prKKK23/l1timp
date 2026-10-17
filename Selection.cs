using System.Collections.Generic;

static class Selection
{
    public static Account[] Apply(Account[] items)
    {
        var result = new List<Account>();
        foreach (var item in items)
        {
            if (item.Active)
            {
                result.Add(item);
            }
        }
        return result.ToArray();
    }
}