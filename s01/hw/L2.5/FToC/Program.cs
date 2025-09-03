namespace FToC;

class Program
{
    static void ftoc(float f){
        float c = (f-32)*5/9;
        Console.Write($"{c:F2}");
    }
    static void Main(string[] args)
    {
        float f = float.Parse(Console.ReadLine());
        ftoc(f);
    }
}
