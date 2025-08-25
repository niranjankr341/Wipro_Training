using System;

class Shape
{
    public virtual void Draw() => Console.WriteLine("Drawing shape");
    public void Area(int side) => Console.WriteLine("Square area: " + side*side);
    public void Area(int l, int b) => Console.WriteLine("Rectangle area: " + l*b);
}

class Circle : Shape
{
    public override void Draw() => Console.WriteLine("Drawing circle");
}

class Program
{
    static void Main()
    {
        Shape s = new Circle();
        s.Draw();
        s.Area(5);
        s.Area(4,6);
    }
}
