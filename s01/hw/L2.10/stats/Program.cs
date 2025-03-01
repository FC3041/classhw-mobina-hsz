dnamespace stats;

class Program
{
    static void Main(string[] args)
    {
        float maximum = -2;
        float minimum = 10;
        int num=0;
        float sum =0;
        while(x!= (-1.0)){
            float x = float.Parse(Console.ReadLine());
            if(x>=maximum) maximum = x;
            if(x<=minimum) minimum = x;
            num++;
            sum+=x;
        }
        float avg = sum/num;
        Console.WriteLine($"{maximum} maximum, {minimum} minimum , {the number of entries} num , {the average} avg");
    }
}
