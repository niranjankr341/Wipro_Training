using System;

class ValueRefDemo
{
    static void Main()
    {
        int x = 10;              // value type
        string msg = "Hi";       // reference type
        Console.WriteLine($"Value: {x}, Reference: {msg}");
    }
}
