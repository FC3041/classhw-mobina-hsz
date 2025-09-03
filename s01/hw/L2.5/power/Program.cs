namespace power;

class Program
{
    static void power(int x,int y){
    int result = 1;
    for(int i=0 ; i<y ; i++){
        result*=x;
    }
    Console.WriteLine(result);
}
    static void Main(string[] args)
    {
        power(2,3);
    }
}
