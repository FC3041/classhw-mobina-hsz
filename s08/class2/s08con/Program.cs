namespace s08con;

class Program
{

    public static void reverse(string s , out string srev){
        srev ="";
        foreach (char c in s)
        {
            srev = c + srev; 
            // it works becuz we add the letters from the beginning of the new str
        }
    }

    public static int add(int a , int b){
        return a+b;
    }

    public static void prepend_user(string s , out string sout){
        sout = "user:" + s;
    }

    public static void reverse_sen(string s1 , out string s2){
        s2 = "";
        foreach(char c in s1){
            if(c == ' '){
                
            }
        }
    }
    // HW take a sentence and make the words backwards like:
    // i like books -> books like i
    // hw2 take a sentence and make all the words backwards

    static void Main(string[] args){

    }

    static void Main2(string[] args){
        string name = "fateme";
        string srev;
        reverse(name , out srev);
        System.Console.WriteLine(srev);
    }

    static void Main1(string[] args)
    {
        int sum = 0;
            while(true){
            System.Console.WriteLine("nums?");
            string s = Console.ReadLine();
            if(string.IsNullOrEmpty(s)) break;
            sum += int.Parse(s);
            
            int n;
            if(! int.TryParse(s,out n)){
                System.Console.WriteLine("wrong! try again");
                continue;
                
            }
            
            string sout;
            prepend_user(s , out sout);
            System.Console.WriteLine(sout);
            sum +=n;
            }
            // out means it did not have value from the begining we are giving the val to it in the function and there is no need for returning anymore
            // tryparse means try to make the s into int and then make it the val of n(out n)
            // the (!) means that if it did not happen 

        
        System.Console.WriteLine(sum);



        // for (int i = 0; i < args.Length; i++)
        // {
        //     System.Console.WriteLine($"args{i}:(args{i})");
        // }
        // Console.WriteLine("Hello, World!");
    }


}
