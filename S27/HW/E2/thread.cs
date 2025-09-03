using System.Numerics;

public class TSDictionary<Tk, Tv>
{
    public Dictionary<Tk, Tv> dict = new Dictionary<Tk, Tv>();
    object lockObject = new object();
    public Tv this[Tk key]
    {
        get
        {
            lock (lockObject)
            {
                return dict[key];
            }
        }
        set
        {
            lock (lockObject)
            {
                dict[key] = value;
            }
        }
    }
}

public class DataFetcher
{
    public static async Task<string> FetchDataAsync(int Delay)
    {
        await Task.Delay(Delay);
        return $"Data fetched afer {Delay}ms";
    }
}

public class TaskLib
{
    public static async Task RunTasksConecutively(Task[] tasks)
    {
        foreach (var task in tasks)
        {
            task.Start();
            await task;
        }
    }

    public static async Task RunTasksInParallel(Task[] tasks)
    {
        foreach (var task in tasks)
            task.Start();
        await Task.WhenAll(tasks);
    }
}