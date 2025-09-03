public class SafeCounter
{
    public int Count { get; set; }
    public object lockobj = new object();
    public void Increment()
    {
        lock (lockobj)
        {
            Count++;
        }
    }
}