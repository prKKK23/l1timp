using System;

class Program
{
    static void Main(string[] args)
    {
        Account[] items = new[]
        {
            new Account("anna", true, "admin"),
            new Account("boris", false, "admin"),
            new Account("vera", true, "user"),
            new Account("gleb", true, "admin")
        };

        Account[] selected = Selection.Apply(items);
        foreach (Account item in selected)
        {
            Console.WriteLine(Formatter.Format(item));
        }

        string summary = Summary.Build(selected);
        if (summary.Length > 0)
        {
            Console.WriteLine(summary);
        }
    }
}