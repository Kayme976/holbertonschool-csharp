using System;
using System.Collections.Generic;

class Dictionary
{
    publoic static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> newDict = new Dictionary<string, int>();

        foreach (KeyValuePair<string, int> entry in myDict)
        {
            newDict[pair.Key] = pair.Value * 2;
        }
        return newDict;
    }
}