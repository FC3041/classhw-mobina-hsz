using System.Diagnostics;

namespace s24;

class Program
{
    static double CPUIntensive()
    {
        int n = 15;
        double d = n;
        for (int i = 0; i < 100_000; i++)
            d = d * Math.Sqrt(n) % n;
        return d;
    }
    static void Main(string[] args)
    {
        //do works in one time(syncronym)
        //task : using Threadpool is hard 
        //Task <return value V>(func which return V type )
        Stopwatch sw = Stopwatch.StartNew();
        Task <double> t = new Task<double>(CPUIntensive);
        t.Start();
        t.Wait();
        sw.Stop();
        System.Console.WriteLine(sw.Elapsed);
        System.Console.WriteLine(t.Result);
    }
    //hw :run debug and learn codes from today
}
