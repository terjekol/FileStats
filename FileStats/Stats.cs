namespace FileStats
{
    public class Stats
    {
        public int LineCount { get; set; }
        public int BlankLineCount { get; set; }
        public int MaxLength { get; set; }

        public override string ToString()
        {
            return $"Ant linjer: {LineCount} Blanke linjer: {BlankLineCount} Max lengde: {MaxLength}";
        }
    }
}
