using System.Net;

namespace FileStats
{
    internal class UrlLineFetcher : ILineFetcher
    {
        public string[] Fetch(string resourceName)
        {
            var webClient = new WebClient();
            return webClient.DownloadString(resourceName).Split('\n');
        }
    }
}
