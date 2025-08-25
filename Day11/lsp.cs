class Bird { public virtual void Fly() => Console.WriteLine("Flying"); }
class Sparrow : Bird { }
class Ostrich : Bird { public override void Fly() => throw new NotImplementedException(); }
