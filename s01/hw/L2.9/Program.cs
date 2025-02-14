namespace L2._9;
using System.Diagnostics;

class Program
{
    static double factorial(int n){
        double result = 1;
        for(int i=1 ; i<n+1 ; i++){
            Debug.Assert(i>0);
            result*=i;
            Debug.Assert(result>0);
        }
        return result;
    }

    static bool is_prime(int n){
        Debug.Assert(n>0);
        if(n==1) return false;
        if(n==2) return true;
        else{
            for(int i=2 ; i<n ; i++){
                if(n%i == 0) return false;
            }
            return true;
        }
    }
    static void Main(string[] args)
    {

        Console.WriteLine("Hello, World!");
    }
}
