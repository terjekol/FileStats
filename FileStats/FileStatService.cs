namespace FileStats
{
    public class FileStatService
    {
        private readonly ILineFetcher _lineFetcher;

        public FileStatService(ILineFetcher lineFetcher)
        {
            _lineFetcher = lineFetcher;
        }

        public Stats GetStats(string filename)
        {
            var lines = _lineFetcher.Fetch(filename);
            var stats = new Stats();
            foreach (var line in lines)
            {
                stats.LineCount++;
                if (line.Length == 0) stats.BlankLineCount++;
                if (line.Length > stats.MaxLength) stats.MaxLength = line.Length;
            }
            return stats;
        }
    }
}
