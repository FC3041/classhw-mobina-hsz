//using function pointer in cs "delegate"

using System.Security.Principal;

class Program{
    delegate int fn_int_2int(int a , int b);

    static void apply(int[] nums1 , int[] nums2 , int[] result , fn_int_2int fn){
        for (int i = 0; i < nums1.Length; i++)
        {
            result[ i] = fn(nums1[i], nums2[i]);
        }
    }

    static void apply2(int[] nums1 , int[] nums2 , int[] result , Func<int , int  , int> fn){
        for (int i = 0; i < nums1.Length; i++)
        {
            result[ i] = fn(nums1[i], nums2[i]);
        }
        //its another way to make a functionpointer USING Func<T>
        //there is no need to use delegate anymore wee can define fn right away in Main?
    }

    static int add(int a , int b) => a+b;
    static int diff(int a , int b) => a-b;
    static int mul(int a , int b) => a*b;

    static void Main(string[] args){
        int[] n1 = new int[3] {1,2,3};
        int[] n2 = new int[3] {-1,-2,-3};
        int[] rs = new int[3];
        apply(n1 , n2 , rs , add);

        foreach(var n in rs){
            System.Console.WriteLine(n);
        }
    }
    //closure means using a funcp that a parameter added or exist in it automatically
    //its one the features in c# cause in the func we have defined for delegate it did not recognize or know that prameter
    //without closure we have to wrtie a class and use its values to define our func
    //wiregaurd VPN
}