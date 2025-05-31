public abstract class Developer
{
    public virtual string Name
    {
        get
        {
            return (IsFemale ? "خانم " : "آقای ") + this.name;
        }
        set => this.name = value;
    }
    public bool IsFemale;
    public string name;

    public Developer(string n, bool f)
    {
        name = n;
        IsFemale = f;
    }

    public abstract int Salary { get; }
}

public class SeniorDeveloper : Developer
{
    public SeniorDeveloper(string n, bool f) : base(n, f)
    {
    }

    public override int Salary => 4_500_000;

    public virtual int CalculateSalary(int hours)
    {
        return Salary + hours * 50_000;
    }
}

public class JuniorDeveloper : Developer
{
    public JuniorDeveloper(string n, bool f) : base(n, f)
    {
    }

    public override int Salary => 2_800_000;
}

public class FullStackDeveloper : SeniorDeveloper
{
    // private string name;

    public FullStackDeveloper(string n, bool f) : base(n, f) { }

    public override string Name { get {
            return "دکتر " +  this.name;
        } set => base.Name = value; }
    public override int Salary => 7_500_000;

    public override int CalculateSalary(int hours)
    {
        return Salary + hours * 70_000;
    }
}