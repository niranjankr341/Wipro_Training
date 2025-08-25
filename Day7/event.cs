using System;

class Publisher
{
    public event Action OnProcessCompleted;

    public void StartProcess()
    {
        Console.WriteLine("Process started...");
        // Do some work
        OnProcessCompleted?.Invoke();
    }
}

class EventDemo
{
    static void Main()
    {
        Publisher pub = new Publisher();
        pub.OnProcessCompleted += () => Console.WriteLine("Process Completed!");
        pub.StartProcess();
    }
}
