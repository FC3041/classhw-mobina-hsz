namespace MoreAsciiiAr;

class Program
{
    static void print_left_triangle(int w){
        for(int i=0; i<w ;i++){
            int k=i+1;
            if(i%2==0){
            for(int j=0 ; j<k;j++)
            Console.Write("*");
            }
            else{
            for(int j=0 ; j<k;j++)
            Console.Write("%");
            }  
            for(int j=0 ;j<w - k;j++)
            Console.Write(" ");
            Console.WriteLine("");
        }
    }
    static void print_cone(int w){
    if(w%2==1){
    int k = ((w-1)/2) + 1;
    for(int i=0 ; i<k ; i++){
        Console.Write(" ");
    }
    Console.Write("^");
    for(int i=0 ; i<k ; i++){
        Console.Write(" ");
    }
    Console.WriteLine("");

    for(int i=1 ; i<k ; i++){
        for(int j=0 ; j<k-i ; j++){
            Console.Write(" ");
        }
        for(int j=0 ; j<i ; j++){
            Console.Write("/");
        }
        Console.Write("|");
        for(int j=0 ; j<i ; j++){
            Console.Write("\\");
        }
        for(int j=0 ; j<k-i ; j++){
            Console.Write(" ");
        }
        Console.WriteLine("");
    //   Console.Write(" " * (k-i)+  i*"/" + "|" + i*"\\" + (k-i)*" ");
        }
    }
}
    static void Main(string[] args)
    {
        print_left_triangle(7);
        for(int i=1 ; i<10 ;i++ ){
            print_cone(i);
        }
    }
}
