using System.Numerics;

namespace s15con;

class Program
{
    static void swap<T>(ref T a , ref T b){
        T temp = a;
        a = b;
        b = temp;
    }

    static T sum<T>(T a , T b)
        where T : INumber<T>
    {

        return (a+b);
    }

    static T sum_nums<T>(T[] nums)
        where T : INumber<T>
    {
        T result = T.Zero;
        for (int i = 0; i < nums.Length; i++)
        {
            result += nums[i];
        }
        return result;
    }

    static T max<T>(T a , T b)
        where T : IComparable<T> // we put the condition that T is comparable
    {
        if(a.CompareTo(b)<0) return b;
        return a;
    }

    

    static void PrintItems<T>(IEnumerable<T> items)
    
    //IEnumerable means that there is more than one thing in the obj
    {
        foreach (T item in items)
        {
            System.Console.WriteLine(item);
        }
    }

    static void PrintItems_me<T>(IEnumerable<T> items){
        //idisposiible?
        //IEnumerable is an interface that has a method which return a value that has the interface IEnumerator
    }

    static T SumItems<T> (IEnumerable<T> items)
        where T : INumber<T>
    {
        T sum = T.Zero;
        foreach (T item in items)
        {
            sum += item;
        }
        return sum;
    }

    static void Main(string[] args){
        int[] nums = new int[]{3,4,5,6,7};
        double[] numsd = new double[]{3.1 , 4.1, 4.5};

        int sum = sum<int>(5, 4);
    }

    //Stack is like List but it  only do it from the end of the array (pop and push) it is similiar to a bag
    //Queue is the oposite of stack it delete and add from the begining

    static void Main2(string[] args)
    {
        int a = 4 ; int b = 6;
        swap(ref a , ref b);
        Console.WriteLine($"a : {a} , b: {b}");

    }
}
//if we wanna use the operators the first element in () should be the same type as the class