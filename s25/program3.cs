using System.Text.RegularExpressions;

namespace S25;

class Program33
{
    static async Task Main33(string[] args)
    {
        using var client = new HttpClient();
        string result = await client.GetStringAsync("https://www.tabnak.ir/"); //its what i have downloaded from {site}
        string pattern = @"(?:src)\s*=\s*[""'](?<url>https?://[^""']+)[""']";
        foreach (Match match in Regex.Matches(result, pattern, RegexOptions.IgnoreCase))
        {
            try
            {
                string url = match.Groups["url"].Value;
                var bytes = client.GetByteArrayAsync(url).Result;
                string filename = Path.GetFileName(url);
                File.WriteAllBytes(filename, bytes);
                Console.WriteLine(filename + " => " + url);
            }
            catch (System.AggregateException ae)
            {
                System.Console.WriteLine(ae.Message);
            }
        }
    }
    //hw : download 2 layers of the website one from the first page the second from the layers
}
