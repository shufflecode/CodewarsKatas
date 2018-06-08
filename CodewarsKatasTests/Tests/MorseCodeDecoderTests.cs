using System;
using CodewarsKatas;
using NUnit.Framework;

namespace CodewarsKatasTests.Tests
{
    [TestFixture()]
    public class MorseCodeDecoderTests
    {
        [Test()]
        public void DecodeTest()
        {
            try
            {
                string input = ".... . -.--  .--- ..- -.. .";
                string expected = "HEY JUDE";

                string actual = MorseCodeDecoder.Decode(input);

                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.Fail("There seems to be an error somewhere in your code. Exception message reads as follows: " + ex.Message);
            }
        }
    }
}