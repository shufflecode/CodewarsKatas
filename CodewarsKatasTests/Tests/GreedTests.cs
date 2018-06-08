using CodewarsKatas;
using NUnit.Framework;

namespace CodewarsKatasTests.Tests
{
    [TestFixture()]
    public class GreedTests
    {
        [Test]
        public static void ShouldBeWorthless()
        {
            Assert.AreEqual(0, Greed.Score(new int[] { 2, 3, 4, 6, 2 }), "Should be 0 :-(");
        }

        [Test]
        public static void ShouldValueTriplets()
        {
            Assert.AreEqual(400, Greed.Score(new int[] { 4, 4, 4, 3, 3 }), "Should be 400");
        }

        [Test]
        public static void ShouldValueMixedSets()
        {
            Assert.AreEqual(450, Greed.Score(new int[] { 2, 4, 4, 5, 4 }), "Should be 450");
        }

        [Test]
        public static void Tripplets1()
        {
            Assert.AreEqual(300, Greed.Score(new int[] { 2, 2, 2, 5, 5 }), "Should be 300");
        }

        [Test]
        public static void Tripplets2()
        {
            Assert.AreEqual(300, Greed.Score(new int[] { 1, 1, 3, 5, 5 }), "Should be 300");
        }

        [Test]
        public static void Tripplets3()
        {
            Assert.AreEqual(300, Greed.Score(new int[] { 3, 3, 3, 2, 2}), "Should be 300");
        }

        [Test]
        public static void Tripplets4()
        {
            Assert.AreEqual(1100, Greed.Score(new int[] { 1, 1, 1, 1, 2 }), "Should be 1100");
        }
    }
}