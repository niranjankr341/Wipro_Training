using System;
using System.Collections.Generic;

class GenericCollectionDemo
{
    static void Main()
    {
        Dictionary<string,int> marks = new Dictionary<string,int>
        {
            {"Math",90}, {"Science",85}
        };
        foreach (var kv in marks)
            Console.WriteLine($"{kv.Key}: {kv.Value}");
    }
}
