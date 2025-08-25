using System;

class LambdaDemo
{
    static void Main()
    {
        Func<int, int, int> add = (x, y) => x + y;
        Action<string> greet = name => Console.WriteLine("Hello " + name);
        Predicate<int> isEven = num => num % 2 == 0;

        Console.WriteLine("Sum: " + add(10, 20));
        greet("Niranjan");
        Console.WriteLine("Is 4 even? " + isEven(4));
    }
}
