namespace s8con;

//dotnet new console --use-program-main -o s8con
//we use -o to give it a adress where to put it
//obj for objects
//we need to make a folder for our test console using dotnet new mstest -o s8con.Test
//if there was not any solution file we can make it by dotnet new sln
//for making proj the interent should be connected
//dotnet sln add  s8con s8con.Test we connect them by this order and the sln file

public class Program
{
    //we should make the program class so the test can read from them
    //we write the tests in unittest or test1.cs
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public int add(int a , int b){
        return a+b;
    }
}
