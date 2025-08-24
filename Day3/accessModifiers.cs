using System;

class AccessDemo
{
    private int privateVal = 10;
    public int GetVal() => privateVal;
}

class Program
{
    static void Main()
    {
        AccessDemo d = new AccessDemo();
        Console.WriteLine("Public Method Output: " + d.GetVal());
    }
}
