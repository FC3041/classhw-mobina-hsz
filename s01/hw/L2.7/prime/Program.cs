namespace prime;

class Program
{
    static bool is_divisble(int a,int b){
    if(a%b==0 && b!=0)
        return true;
    return false;
}

static bool is_prime(int n){
    if (n==1) return false;
    else if (n==2) return true;
    else
        for(int i=2 ; i<n ; i++){
            if (is_divisble(n,i)) return false;
        }
        return true;
}
    static void Main(string[] args){
    for( int i=1 ;i<100 ;i++){
        if (is_prime(i)) Console.WriteLine(i);
    }
    }
}
