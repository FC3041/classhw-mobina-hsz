namespace fibonacci;

class Program
{
    static int fibonacci(int n){
        int a=1;
        int b=1;
        for(int i=0 ; i<n-2 ; i++){
            int temp = a;
            a+=b;
            b= temp;
        }
        return a;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(fibonacci(6));
    }
}
