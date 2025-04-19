namespace s16con;

class Program
{
    static void print_citizens(Citizen[] cs){
        foreach(var c in cs){
            System.Console.WriteLine(c.ToString());
            //it`ll calls the ToString of its own
        }
    }
    static void Main(string[] args)
    {
        
    }
}
