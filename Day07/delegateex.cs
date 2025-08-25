using System;

delegate int MathOperation(int a, int b);

class DelegateDemo
{
    static int Add(int a, int b) => a + b;
    static int Multiply(int a, int b) => a * b;

    static void Main()
    {
        MathOperation op = Add;
        Console.WriteLine("Addition: " + op(5, 3));

        op = Multiply;
        Console.WriteLine("Multiplication: " + op(5, 3));
    }
}
