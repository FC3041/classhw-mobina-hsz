class Program
{
    static void Main(string[] args)
    {
        using var client = new HttpClient();
        string result =
            client.GetStringAsync("site").Result; 
        System.Console.WriteLine(result);
    }
    // this will write the {site} for us

    //regular experesion => you can find the things that are similiar in a way like they all have https
    //+ means 1 less or more 
    //* means 0 or more 
}