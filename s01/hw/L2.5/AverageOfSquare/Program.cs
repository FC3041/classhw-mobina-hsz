namespace AverageOfSquare;

class Program
{
    static int power(int x,int y){
    int result = 1;
    for(int i=0 ; i<y ; i++){
        result*=x;
    }
    return result;
}

    static bool is_sqr(int n){
    for(int i=0 ; i<=n/2 ; i++){
        if(power(i,2)==n)
        return false;
    }
    return true;
}

    static void average_of_squares(int n){
    int sum =0;
    int num = 0;
    for (int i=0 ; i<n ; i++){
        if (is_sqr(i)){
            sum+=i;
            num+=1;
        }
    }
    int avg = sum/2;
    Console.WriteLine(avg);
}

static void average_of_squares1(int n){
    int sum =0;
    int num = 0;
    for (int i=1 ; i<n+1 ; i++){
        if (is_sqr(i)){
            sum+=i;
            num+=1;
        }
    }
    int avg = sum/2;
    Console.WriteLine(avg);
}
    static void Main(string[] args)
    {
        average_of_squares(5);
        average_of_squares1(5);
    }
}
