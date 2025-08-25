using System;

class BubbleSortDemo
{
    static void Main()
    {
        int[] arr = { 5, 2, 8, 1, 3 };
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Sorted Array: " + string.Join(", ", arr));
    }
}
