
public class LambdaProblems
{
    // public string sentence;
    // public static int GetStringLengthCalculator() => sentnece.length;
    public static Func<string, int> GetStringLengthCalculator()
    {
        return (x) => x.Length;
    }

}