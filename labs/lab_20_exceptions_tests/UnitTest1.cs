using NUnit.Framework;
using System;
using lab_20_exceptions;

namespace lab_20_exceptions_tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(-1)]
        [TestCase(4)]
        public void Test1(int pos)
        {
            var ex = Assert.Throws<ArgumentException>(() => Program.AddBeatle(pos, "Brian"));
            Assert.AreEqual($"The Beatles do not have a position {pos}", ex.Message, "Exception message not correct");
        }
    }
}