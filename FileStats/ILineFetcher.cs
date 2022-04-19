namespace FileStats
{
    internal interface ILineFetcher
    {
        string[] Fetch(string resourceName);
    }
}
