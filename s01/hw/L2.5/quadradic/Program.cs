namespace quadradic;

class Program
{
static void awnser(int a , int b , int c){
    int delta =b*b -4*a*c;
    if(delta>0){
        double x1= (-b + Math.Pow(delta,0.5))/2*a;
        double x2 = (-b - Math.Pow(delta,0.5))/2*a;
        Console.WriteLine(x1);
        Console.WriteLine(x2);
    }
    if (delta==0){
        int x = -2/2*a;
        Console.WriteLine(x);
    }
    if(delta<0){
        Console.WriteLine("there is no real awnser for this problem");
    }
}
    static void Main(string[] args)
    {
        awnser(1,2,1);
    }
}
