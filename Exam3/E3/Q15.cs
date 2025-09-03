

public abstract class IStage<T>
{
    protected IStage<T> _nextStage;
    public abstract string? Handle(string input);

    public void log(string input)
    {
        string output = Handle(input);
        _nextStage.log(output);
    }
    public IStage<T>? SetNext(IStage<T> nextStage)
    {
        _nextStage = nextStage;
        return _nextStage;
    }
}
public class SuffixStage : IStage<string>
{
    private string v;

    public SuffixStage(string v)
    {
        this.v = v;
    }

    public override string? Handle(string input)
    {
        return input + v;

    }
}

public class UpperStage : IStage<string>
{
    public override string? Handle(string input)
    {
        return input.ToUpper();
    }
}

public class TrimStage : IStage<string>
{
    public override string? Handle(string input)
    {
        return input.Trim();
    }
}