namespace FileStats.Test
{
    internal class MockLineFetcher : ILineFetcher
    {
        public string[] Fetch(string resourceName)
        {
            return new[]
            {
                "kdjshgfsg",
                "kdjshgfsg",
                "kdjshgfsg",
                "0123456789012345678901234567890123456789",
                "",
                "",
                "",
            };
        }
    }
}
