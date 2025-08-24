using System;

class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Hello .NET World!");
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Welcome, {name}");
    }
}
