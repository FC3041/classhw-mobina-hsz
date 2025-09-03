public class Animal
{
    public virtual string MakeSound() { return "Some generic animal sound"; }

}

public class Dog : Animal
{
    public override string MakeSound()
    {
        return "Woof";
    }

}

