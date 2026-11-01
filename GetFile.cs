using System.Runtime.CompilerServices;

namespace GetFile;

public class Tool
{
    private static HttpClient c = new HttpClient();
    public static async Task Get(string url)
    {
        try {
        var e = await c.GetAsync(url);
        e.EnsureSuccessStatusCode();
        string filename = Path.GetFileName(new Uri(url).LocalPath);
        var Content = await e.Content.ReadAsByteArrayAsync();

        await File.WriteAllBytesAsync(filename, Content);
        

        }
        
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}
