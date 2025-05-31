using System.Security.Cryptography.X509Certificates;

class delegates
{
    public double add(int a, int b) => a + b;
    public double sub(int a, int b) => a - b;
    public double multipy(int a , int b) => a * b;
    public double devide(int a, int b) => a / b;
    public delegate double operation(int a, int b);
    public static void Main(String[] args)
    {
        string opt = (Console.ReadLine());
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        delegates del = new delegates();

        if (opt == "+")
        {
            operation Add = new operation(del.add);
            System.Console.WriteLine(Add(a, b));
        }
        else if (opt == "-")
        {
            operation Sub = new operation(del.sub);
            System.Console.WriteLine(Sub(a, b)); 
        }
    }
    
}

