using NUnit.Framework;
using RainDrop;
using System;

namespace RainDropTest
{
    public class RainDropInputTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Category("Happy")]
        [Test]
        public void WhenAGivenValueIsConvertedToString()
        {
            var result = Program.PlingPlangPlong(28);
            Assert.That(result, Is.TypeOf<string>());
        }

        [Category("Sad")]
        [Test]
        public void WhenAnInvalidUserInputIsReturnedException()
        {
            Assert.That(() => Program.ConvertUserInputToNumber("test"), Throws.Exception);
        }

        [Category("Happy")]
        [TestCase(28, "Plong")]
        [TestCase(30, "PlingPlang")]
        [TestCase(34, "34")]
        public void WhenAGivenNumberReturnsAStringBasedOnNumbersFactors(int x, string expected)
        {
            var result = Program.PlingPlangPlong(x);
            Assert.That(result,Is.EqualTo(expected));
        }
    }
}