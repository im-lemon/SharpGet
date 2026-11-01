using GetFile;

public class Program
{
    public static async Task Main(string[] args)
    {
        if (args.Length >= 1)
        {
            foreach (string a in args)
            {
                await GetFile.Tool.Get(a);
            }
        }
    }
}