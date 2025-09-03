public class Comparer<T> where T : IComparable<T>
{
    public T obj1 { get; set; }
    public T obj2 { get; set; }
    public Comparer(T o1, T o2)
    {
        this.obj1 = o1;
        this.obj2 = o2;
    }

    public T GetLarger()
    {
        return (obj1.CompareTo(obj2) > 0) ? obj1 : obj2;
    }
}

public class Product : IComparable<Product>
{
    public string Name { get; set; }
    public int Price { get; set; }

    public int CompareTo(Product? other)
    {
        return Price.CompareTo(other.Price);
    }
}