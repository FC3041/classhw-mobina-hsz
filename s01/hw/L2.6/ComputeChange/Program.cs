namespace ComputeChange;

class Program
{
    static void compute_change(int c){
        int t  = 100 - c;
        int q=0; int d=0; int n=0;int p=0;
        while (t!=0){
        if (t>=25) {
            q=t/25;
            t= t%25;
        }
        else if(t>=10){
            d = t/10;
            t=t%10;
        }
        else if(t>=5){
            n=t/5;
            t = t%5;
        }
        else if(t>0){
            p=t;
            t=0;
        }
        }
        Console.WriteLine($"quarters : {q}");
        Console.WriteLine($"dime : {d}");
        Console.WriteLine($"nickel : {n}");
        Console.WriteLine($"pennies : {p}");
    }
    static void Main(string[] args)
    {
        compute_change(8);
    }
}
