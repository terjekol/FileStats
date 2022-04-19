using System;
using Moq;
using NUnit.Framework;

namespace FileStats.Test
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            // arrange
            var mockLineFetcher = new MockLineFetcher();
            var fileStatService = new FileStatService(mockLineFetcher);

            // act
            var stats = fileStatService.GetStats(null);

            // assert
            Assert.AreEqual(7, stats.LineCount);
            Assert.AreEqual(3, stats.BlankLineCount);
            Assert.AreEqual(40, stats.MaxLength);
        }

        [Test]
        public void Test2()
        {
            // arrange
            var mockLines = new[]
            {
                "kdjshgfsg",
                "kdjshgfsg",
                "kdjshgfsg",
                "0123456789012345678901234567890123456789",
                "",
                "",
                "",
            };
            var mock = new Mock<ILineFetcher>();
            mock
                .Setup(lf => lf.Fetch(It.IsAny<string>()))
                .Returns(mockLines);

            var fileStatService = new FileStatService(mock.Object);

            // act
            var stats = fileStatService.GetStats(null);

            // assert
            Assert.AreEqual(7, stats.LineCount);
            Assert.AreEqual(3, stats.BlankLineCount);
            Assert.AreEqual(40, stats.MaxLength);
            mock.Verify(
                lf=>lf.Fetch(It.IsAny<string>()), 
                Times.Once);
        }
    }
}