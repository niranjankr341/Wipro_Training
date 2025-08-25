abstract class Shape { public abstract double Area(); }
class Circle : Shape { public double Radius; public override double Area() => 3.14 * Radius * Radius; }
class Square : Shape { public double Side; public override double Area() => Side * Side; }
