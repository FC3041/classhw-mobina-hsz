namespace s7cs;

class Program
{
    static void update(int [] nums){
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i]++;
        }
    }
    static void Main(string[] args)
    {
        int  [] num = new int[10];
        update(num);
        for (int i = 0; i < num.Length; i++)
        {
            Console.WriteLine(num[i]);
        }
        Console.WriteLine("Hello, World!");
    }
}
