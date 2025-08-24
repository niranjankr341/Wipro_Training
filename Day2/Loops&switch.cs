//LOOPS & SWITCH

using System;

class LoopDemo
{
    static void Main()
    {
        for (int i=0; i<3; i++) Console.WriteLine("For: " + i);

        int count = 0;
        while (count < 2) { Console.WriteLine("While"); count++; }

        int option = 2;
        switch(option)
        {
            case 1: Console.WriteLine("One"); break;
            case 2: Console.WriteLine("Two"); break;
            default: Console.WriteLine("Other"); break;
        }
    }
}
