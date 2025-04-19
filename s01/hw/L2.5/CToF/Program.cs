namespace CToF;

class Program
{
    static void ctof(float c){
        float f = (9*c/5)+32;
        Console.Write(Math.Round(f,2));
    }
    static void Main(string[] args)
    {
        float c = float.Parse(Console.ReadLine());
        ctof(c);
    }
}