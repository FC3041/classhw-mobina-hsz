namespace factorial;

class Program
{

    static void factorial(double n){
    double result = 1;
    for (double i=1 ; i<n+1 ; i++){
        result*=i;
    }
    Console.WriteLine(result);
}
    static void Main(string[] args)
    {
        for(int i=1 ; i<20 ; i++){
            factorial(i);
        }
    }
}


