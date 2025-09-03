public class Program
{
    static void Do1(object obj)
    {
        try
        {
            System.ConsoleColor c = (System.ConsoleColor) obj;
            while(true)
            {   
                System.ConsoleColor pc = Console.ForegroundColor;
                Console.ForegroundColor = c;
                System.Console.WriteLine(c.ToString());
                Console.ForegroundColor = pc;
                Thread.Sleep(500);
            }
        }
        catch{}
        {
            System.Environment.Exit(-1);
        }
    }
    //join in thread will wait for the threads

    public static void Main(string[] args)
    {
        Thread t = new Thread(Do1);
        t.Start(System.ConsoleColor.Yellow);
        Thread t2 = new Thread(Do1);
        t2.Start(System.ConsoleColor.Cyan);        
        while(true)
        {
            System.Console.WriteLine("Main");
            Thread.Sleep(500);
        }        
    }
}