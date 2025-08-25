using System;

class ExceptionDemo
{
    static void Main()
    {
        try
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = 100 / num;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Cannot divide by zero!");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: Please enter a valid integer.");
        }
        finally
        {
            Console.WriteLine("Execution completed.");
        }
    }
}
