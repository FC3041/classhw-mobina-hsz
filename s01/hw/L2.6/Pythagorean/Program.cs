namespace Pythagorean;

class Program
{
    static void Main(string[] args)
    {
        for (int c=3 ; c<100 ; c++){
            for(int b=2 ;b<c ;b++ ){
                for (int a = 1 ; a<b ; a++){
                    if(a*a+ b*b == c*c)
                    {
                        Console.Write($"a={a} ");
                        Console.Write($"b={b} ");
                        Console.WriteLine($"c={c}");
                    }
                }
            }
        }
    }
}
