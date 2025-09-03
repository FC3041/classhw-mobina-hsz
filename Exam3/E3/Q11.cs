public interface Closures
{
    public static int c=0;
    public static Func<int> CreateCounter()
    {
        return new Func<int>(() => c++);
    }
}