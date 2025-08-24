using System;

class Calculator
{
    public int Multiply(int a, int b) => a*b; // instance
    public static int Add(int a, int b) => a+b; // static
}

class Program
{
    static void Main()
    {
        Console.WriteLine(Calculator.Add(2,3));
        Calculator c = new Calculator();
        Console.WriteLine(c.Multiply(4,5));
    }
}
