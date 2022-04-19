namespace FileStats
{
    public interface ILineFetcher
    {
        string[] Fetch(string resourceName);
    }
}
