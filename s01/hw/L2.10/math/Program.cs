namespace math;
using System.Diagnostics;
class Program
{
    static double eulers_constant(double precision){
        double result = 0;
        double nxtsmmnd=1;
        int count = 0;
        while(nxtsmmnd>precision){
            result +=nxtsmmnd;
            count ++;
            nxtsmmnd = 1/factorial(count);
        }
        return result;
    }
    static double factorial(double n){
        double result = 1;
        for(int i=1 ; i<n+1 ; i++){
            result*=i;
        }
        return result;
    }

    static double power(double a , int b){
        double resutl = 1;
        for(int i=0 ; i<b ; i++){
            resutl*=a;
        }
        return resutl;
    }    

    static double exp(double x,double precision){
        double result = 0;
        double nxtsmmnd=1;
        int count = 0;
        while(nxtsmmnd>precision){
            result +=nxtsmmnd;
            count ++;
            nxtsmmnd = (power(x,count))/factorial(count);
        }
        return result;
    }

    static double exp2(double x,double precision){
        double result = 0;
        double nxtsmmnd=1;
        int count = 0;
        while(nxtsmmnd>precision){
            result +=nxtsmmnd;
            count ++;
            nxtsmmnd*=(x/count);
    }
        return result;
    }

    static double abs(double x){
        if(x>0) return x;
        return -x;
    } 

    static double max(double x, double y){
        if(x>y) return x;
        return y;
    }

    static bool near(double x , double y , double clossness=0.001){
        if(abs(x-y)>max(x,y)*clossness) return false;
        return true;
    }

    static double sin(double x,double precision){
        double result = 0;
        double nxtsmmnd=1;
        int count = 0;
        int count2=0;
        while(abs(nxtsmmnd)>abs(precision)){
            count ++;
            nxtsmmnd*=(power(-1,count2))*(x/count);
            if(count%2==1){
            result +=nxtsmmnd;
            count2++;}
            else result+=0;
        }
        return result;
    }

    static double square_root(double x, double precision){
        Debug.Assert(x>=0);
        double lowerbound= 0;
        double upperbound = x;
        while(upperbound - lowerbound > precision){
            double mid = (upperbound+lowerbound)/2;
            if((mid*mid)<= x) lowerbound = mid;
            else upperbound = mid;
        }
        return upperbound;
    }

    static double root(double x,int n, double precision){
        double lowerbound= 0;
        double upperbound = x;
        while(upperbound - lowerbound > precision){
            double mid = (upperbound+lowerbound)/2;
            if((power(mid,n))<= x) lowerbound = mid;
            else upperbound = mid;
        }
        return upperbound;
    }

    static double calculate_ln(double x , double precision){
        double lowerbound = 0 ;
        double upperbound = x;
        while(upperbound - lowerbound>precision){
            double mid = (upperbound + lowerbound)/2;
            if(exp(mid,precision)<=x) lowerbound =mid;
            else upperbound = mid;
        }
        return upperbound;
    }
    static void Main(string[] args)
    {
        Console.WriteLine($"e = {eulers_constant(0.001)}");
        Console.WriteLine($"e={exp(1,0.001)}");
        Console.WriteLine($"e*e = {exp(2,0.001)}");
        Console.WriteLine($"e with exp2 = {exp2(1,0.001)}");
        Console.WriteLine($"near exp , exp2 = {near(exp(1,0.001), exp2(1,0.001))}");
        Console.WriteLine($"sin 45 = {sin(3.14/4,0.001)}");
        Console.WriteLine($"sin 0 = {sin(0,0.001)}");
        Console.WriteLine($"sin 90= {sin(3.14/2,0.001)}");
        Console.WriteLine($"squeare_root of 2 = {square_root(2, .000001)}");
        Console.WriteLine($"root3 of 8 = {root(8,3,0.00001)}");
        Console.WriteLine($"ln 2.7 = {calculate_ln(2.7,0.0001)}");

    }
}
