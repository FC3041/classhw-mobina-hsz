namespace absolute;

class Program
{
    static int absolute_value(int x){
        if(x>0) return x;
        return -x;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(absolute_value(100));
        Console.WriteLine(absolute_value(-100));
        Console.WriteLine(absolute_value(0));
        Console.WriteLine(absolute_value(1));
        Console.WriteLine(absolute_value(-1));
    }
}
