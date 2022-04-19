using System;

namespace FileStats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var stats = FileStatService.GetStats("test.txt");
            //Console.WriteLine(stats);

            //var lines = File.ReadAllLines("test.txt");
            //var stats = FileStatService.GetStats(lines);
            //Console.WriteLine(stats);

            //var fileLineFetcher = new FileLineFetcher();
            //var fileStatService = new FileStatService(fileLineFetcher);
            //var stats = fileStatService.GetStats("test.txt");
            //Console.WriteLine(stats);

            var urlLineFetcher = new UrlLineFetcher();
            var fileStatService = new FileStatService(urlLineFetcher);
            var stats = fileStatService.GetStats("https://www.vg.no/");
            Console.WriteLine(stats);
        }
    }
}
