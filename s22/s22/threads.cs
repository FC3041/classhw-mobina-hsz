using System.Security.Cryptography.X509Certificates;

public class Mythread
{
    public delegate void MythreadDelegate();
    public Mythread(MythreadDelegate func)
    {

    }
}

class threads
{
    public static void Main(string[] args)
    {
        var mythr = new Mythread(Thread1Job);
    }

    public static void Thread1Job()
    {
        for (int counter = 0; counter < 50; counter++)
        {
            Console.WriteLine("From thread1: " + counter);
        }
    }

    public static void functio(Func f())
    {
        
    }
}


