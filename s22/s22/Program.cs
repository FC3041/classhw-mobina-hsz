namespace s22;

class Program
{
    static void Main2(string[] args)
    {
        var thread1 = new Thread(Thread1Job);
        var thread2 = new Thread(Thread2Job);
        var thread3 = new Thread(Thread3Job);
        thread2.Start();
        thread1.Start();
        thread3.Start();

}



public static void Thread2Job()
{
    for (int counter = 0; counter < 50; counter++)
    {
        Console.WriteLine("From thread2: " + counter);
    }
}

public static void Thread3Job()
{
    for (int counter = 0; counter < 50; counter++)
    {
        Console.WriteLine("From thread3: " + counter);
    }
}
}
