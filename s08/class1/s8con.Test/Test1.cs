namespace s8con.Test;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestMethod1()
    {
        int x= 1;
        Assert.AreEqual(x+1,2);
        //we write dotnet test in the terminal to see the test pass or not

    }

    public void TestMethod2()
    {
        int result = Program.add(3,5);
        //if we want to have access to "Program" we will write dotnet add reference ..\s8con in the terminal
        Assert.AreEqual(result , 8);
    }
}
