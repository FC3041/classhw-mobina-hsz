public class ResourceManager : IDisposable
{
    public void Dispose()
    {
        IsDisposed = true;
    }

    public bool IsDisposed;
}