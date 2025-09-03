
public class Publisher
{
    public void RaiseEvent(string v)
    {
        throw new NotImplementedException();
    }
}

public class Subscriber
{
    private Publisher publisher;

    public Subscriber(Publisher p)
    {
        this.publisher = p;
    }

    public List<string> ReceivedMessages { get; set; }

    public void Unsubscribe()
    {
        throw new NotImplementedException();
    }
}