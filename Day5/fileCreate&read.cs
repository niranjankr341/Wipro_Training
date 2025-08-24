using System;
using System.IO;

class FileDemo
{
    static void Main()
    {
        string path = "data.txt";
        File.WriteAllText(path, "Hello File");
        string content = File.ReadAllText(path);
        Console.WriteLine(content);
    }
}
