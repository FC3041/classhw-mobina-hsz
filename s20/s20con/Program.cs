namespace s20con;

class Program
{
    public static (int , int ,double) AnalyzeList(List<int> numbers){
        int min = numbers.Min();
        int max = numbers.Max();
        double avg = numbers.Average();
        avg = Math.Round(avg , 2);
        return(min , max , avg);
    }
    static void Main(string[] args)
    {
        //Tuple
        //we can use multiple types in tuple

        Tuple<string,int> t1 = new Tuple<string, int>("Mobina" , 19);
        System.Console.WriteLine(t1.Item1);

        var t2 = new Tuple<string,int, int>("Zoha" , 20 , 1332);
        //using var

        var t3 = Tuple.Create<string,int>("Mobina" , 19);
        //using "Create" instead of "New"

    }
    static void Main2(string[] args)
    {
        string name = "computer12345";
        string name2 =name.TitleCase();
        System.Console.WriteLine(name2);
        System.Console.WriteLine(name.CountDigits());
    }
    static void Main1(string[] args)
    {
        int x = 5;
        double y = 6;
        // y = x -> it is OK (implicit)
        //x = (int) y; casting explicit (it is OK to lose some info)

        ComplexNumber c1 = new ComplexNumber(2,6);
        ComplexNumber c2 = new ComplexNumber(1,5);

        y =  (double)c1;
        c2 = x;
        c2.printCN();

    }
    static void Main0(string[] args)
    {
        ComplexNumber c = new ComplexNumber(2,6);
        c.printCN();
        System.Console.WriteLine(c[0]);
        System.Console.WriteLine(c[true]);
    }
}
