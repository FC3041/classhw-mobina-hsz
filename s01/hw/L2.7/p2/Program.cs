namespace p2;

class Program
{
    static double factorial(int n){
    double result = 1;
    for (double i=1 ; i<n+1 ; i++){
        result*=i;
    }
    return result;
}
    static void Main(string[] args)
    {
        for(int i=1 ; i<20 ; i++){
            Console.WriteLine(factorial(i));
        }
    }
}
