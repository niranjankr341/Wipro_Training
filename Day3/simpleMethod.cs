using System;

class MethodDemo
{
    static void PrintMessage(string msg) => Console.WriteLine(msg);
    static int Add(int a, int b) => a + b;

    static void Main()
    {
        PrintMessage("Hello from method");
        Console.WriteLine("Sum: " + Add(3,4));
    }
}
