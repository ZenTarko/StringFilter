using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] input = { "Hello", "2", "world", ":-)" };
        string[] filteredStrings = FilterShortStrings(input);
        Console.WriteLine("Filtered strings:");
        foreach (string str in filteredStrings)
        {
            Console.WriteLine(str);
        }
    }

    static string[] FilterShortStrings(string[] input)
    {
        List<string> result = new List<string>();
        foreach (string str in input)
        {
            if (str.Length <= 3)
            {
                result.Add(str);
            }
        }
        return result.ToArray();
    }
}
