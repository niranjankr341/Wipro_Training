//Single & Multi-Dimensional Arrays
using System;

class ArrayDemo
{
    static void Main()
    {
        int[] arr = {1,2,3};
        Console.WriteLine("Single: " + arr[1]);

        int[,] matrix = { {1,2}, {3,4} };
        Console.WriteLine("Matrix element: " + matrix[1,0]);
    }
}
