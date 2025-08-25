using System;

class AgeException : Exception
{
    public AgeException(string message) : base(message) { }
}

class CustomExceptionDemo
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age < 18)
            throw new AgeException("Age must be 18 or above to register.");

        Console.WriteLine("Registration successful!");
    }
}
