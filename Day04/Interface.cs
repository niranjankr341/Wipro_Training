using System;

interface IMovable
{
    void Move();
}

class Car : IMovable
{
    public void Move() => Console.WriteLine("Car moves");
}

class Program
{
    static void Main()
    {
        IMovable obj = new Car();
        obj.Move();
    }
}
