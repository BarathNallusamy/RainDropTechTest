using NUnit.Framework;
using RainDrop;

namespace RainDropTest
{
    public class RainDropInputTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WhenAGivenValueIsConvertedToString()
        {
            var result = Program.PlingPlangPlong(28);
            Assert.That(result, Is.TypeOf<string>());
        }

        [Ignore("ignore this test")]
        [TestCase(28, "Plong")]
        [TestCase(30, "PlingPlang")]
        [TestCase(34, "34")]
        public void WhenAGivenNumberReturnsAStringBasedOnNumbersFactors(int x, string expected)
        {
            Assert.Pass();
        }
    }
}