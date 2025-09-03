public abstract class Developer
{
    public virtual string Name
    {
        get
        {
            return (IsFemale ? "خانم " : "آقای ") + name;
        }
        set => name = value;
    }
    public bool IsFemale;
    public string name;
    public abstract int Salary { get; }

    public Developer(string name, bool isFemale)
    {
        Name = name;
        IsFemale = isFemale;
    }

}


public class SeniorDeveloper : Developer
{
    public SeniorDeveloper(string name, bool isFemale) : base(name, isFemale) { }
    public override int Salary => 4_500_000;
    public virtual int CalculateSalary(int hour)
    {
        return Salary + hour * 50_000;
    }
}

public class JuniorDeveloper : Developer
{
    public JuniorDeveloper(string name, bool isFemale) : base(name, isFemale) { }
    public override int Salary => 2_800_000;

}

public class FullStackDeveloper : SeniorDeveloper
{
    public FullStackDeveloper(string name, bool isFemale) : base(name, isFemale)
    {
        
    }
    public override string Name
    {
        get { return "دکتر " + name; }
        set { name = value; }
    }

    public override int Salary => 7_500_000;
    public override int CalculateSalary(int hour)
    {
        return Salary + hour * 70_000;
    }
}