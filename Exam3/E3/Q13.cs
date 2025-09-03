public class DataService
{
    public async Task<string> FetchDataAsync(string userId)
    {
        Task.Delay(100);
        return $"Data for {userId}";
    }
}