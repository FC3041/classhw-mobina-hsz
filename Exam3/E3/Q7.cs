
public class DelegateProblems
{
    public delegate string StringOperation(string input);
    public static string ProcessString(string input, StringOperation operation)
    {
        return operation(input);
    }

    public static string ToUpper(string input)
    {
        return input.ToUpper();
    }

    public static string ToLower(string input)
    {
        return input.ToLower();
    }
    // public StringOperation ToUpper(string input) => input. ;
}