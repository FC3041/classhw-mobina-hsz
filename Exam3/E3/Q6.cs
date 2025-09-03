using System.Numerics;

public struct Money : IEquatable<Money>
{
    public int Amount { get; set; }
    public string Country { get; set; }

    public Money(int amount, string country)
    {
        Amount = amount;
        Country = country;
    }

    public static Money operator +(Money m1, Money m2)
    {
        Money ans = new Money(m1.Amount + m2.Amount, m1.Country);

        return ans;
    }

    public bool Equals(Money other)
    {
        return Amount == other.Amount && Country == other.Country;
    }

    public static bool operator ==(Money a, Money b)
    {
        return a.Equals(b);
    }

    public static bool operator !=(Money a, Money b)
    {
        return !(a == b);
    }
}