using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread low = new Thread(Work) { Priority = ThreadPriority.Lowest };
        Thread normal = new Thread(Work) { Priority = ThreadPriority.Normal };
        Thread high = new Thread(Work) { Priority = ThreadPriority.Highest };

        low.Start("Low");
        normal.Start("Normal");
        high.Start("High");

        low.Join();
        normal.Join();
        high.Join();
    }

    static void Work(object name)
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"{name} Priority: {i}");
            Thread.Sleep(100);
        }
    }
}