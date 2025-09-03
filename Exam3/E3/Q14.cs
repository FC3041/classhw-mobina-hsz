using System.Reflection.Metadata;

public class Order
{
    public Guid Id { get;  set; }
}

public class Customer
{
    public Guid Id { get; set; }
}

public class Repository<T> where T : new()
{

    public Customer CreateNew()
    {
        throw new NotImplementedException();
    }
}