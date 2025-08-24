using System;
using System.Collections;

class CollectionDemo
{
    static void Main()
    {
        ArrayList list = new ArrayList {1,"two",3.0};
        foreach (var item in list)
            Console.WriteLine(item);
    }
}
