//Jagged Array

using System;

class JaggedArrayDemo
{
    static void Main()
    {
        int[][] jagged = new int[2][];
        jagged[0] = new int[] { 1, 2 };
        jagged[1] = new int[] { 3, 4, 5 };

        foreach (var arr in jagged)
        {
            Console.WriteLine(string.Join(",", arr));
        }
    }
}
