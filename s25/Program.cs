using System.ComponentModel;
using System.Text.RegularExpressions;

namespace S25;

class Program
{
    static double dowork(object obj)
    {
        double n = (double)obj;
        System.Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} => {n}");
        double d = 1;
        for (int i = 1; i < n; i++)
            d = (d * i) % 1023;
        return d;
    }

    static async Task Main6(string[] args)
    {
        double lastValue = 1000;
        for (int i = 0; i < 20; i++)
        {
            lastValue = await Task<double>.Factory
            .StartNew(dowork, lastValue);
        }

        //it will wait for the other task to come and finish

    }
    static void Main5(string[] args)
    {
        Task<double> task = null;
        double lastValue = 1000;
        for (int i = 0; i < 20; i++)
        {
            task = Task<double>.Factory
            .StartNew(dowork, lastValue);
            lastValue = task.Result;
        }
        task.Wait();

    }

    static void Main4(string[] args)
    {
        // var tasks = new Task<double>[19];
        double sum = 0;
        List<Task> tasks = new List<Task>();
        for (int i = 1; i < 20; i++)
        {
            var t = Task<double>.Factory
            .StartNew(dowork, i * 1000)
            .ContinueWith(t => sum += t.Result);
            tasks.Add(t);
            //the return value from dowork will be the value of the next task

            //.StartNew(dowork, i * 10_000_000)
            //.ContinueWith(t => sum += t.Result);
            //the same as "var t = Task<double>.Factory.StartNew(dowork, i * 10_000_000)"
            //t.ContinueWith(t => sum += t.Result);
        }
        Task.WaitAll(tasks.ToArray());
        System.Console.WriteLine(sum);

        //it is different from the before cause the tasks will be done soon and may interrupt each other
    }

    static void Main3(string[] args)
    {
        var tasks = new Task<double>[19];
        double sum = 0;
        for (int i = 1; i < 20; i++)
        {
            tasks[i - 1] = Task<double>.Factory.StartNew(dowork, i * 10_000_000);
        }
        Task.WaitAll(tasks);

        foreach (var t in tasks)
            sum += t.Result;
        System.Console.WriteLine(sum);
    }

    static void Main2(string[] args)
    {
        var t = Task.Run(() => dowork(10_000_000));
        while (true)
        {
            if (t.Status == TaskStatus.RanToCompletion)
                break;
            System.Console.WriteLine("Waiting");
            Task td = Task.Delay(10);
            td.Wait();
        }
        System.Console.WriteLine(t.Result);
    }
}
