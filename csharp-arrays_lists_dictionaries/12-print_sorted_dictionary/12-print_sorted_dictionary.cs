using System;
unsing System.Linq;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        var keys = myDict.Keys.ToList();
        keys.Sort();
        foreach (var key in keys)
        {
            Console.WriteLine("{0}: {1}", key, myDict[key]);
        }
    }
}