using System;
using System.Text;

class StringDemo
{
    static void Main()
    {
        string s = "Hello";
        s += " World";
        Console.WriteLine("String: " + s);

        StringBuilder sb = new StringBuilder("Hello");
        sb.Append(" World");
        Console.WriteLine("StringBuilder: " + sb);
    }
}
