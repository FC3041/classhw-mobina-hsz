namespace L2._4;

class Program
{
    public static void print_left_triangle(int w){
        for(int i=0; i<w ;i++){
            int k=i+1;
            for(int j=0 ; j<k;j++)
            Console.Write("*");
            for(int j=0 ;j<w - k;j++)
            Console.Write(" ");
            Console.WriteLine("");
        }
    }

    public static void print_right_triangle(int w){
        for(int i=0; i<w ;i++){
            int k=i+1;
            for(int j=0 ;j<w - k;j++)
            Console.Write(" ");
            for(int j=0 ; j<k;j++)
            Console.Write("*");
            Console.WriteLine("");
        }
    }    

    static void Main(string[] args)
    {
        print_left_triangle(20);
        print_right_triangle(5);
    }
}
