using System.IO;

namespace FileStats
{
    internal class FileLineFetcher : ILineFetcher
    {
        public string[] Fetch(string resourceName)
        {
            return File.ReadAllLines(resourceName);
        }
    }
}
