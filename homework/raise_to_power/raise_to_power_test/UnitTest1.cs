using NUnit.Framework;
using raise_to_power;

namespace raise_to_power_test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(2, 3, 3, 216)]
        [TestCase(2, 2, 2, 16)]
        [TestCase(5, 8, 9, 262144000000000)]
        [TestCase(2, 1, 5, 32)]
        [TestCase(4, 4, 4, 65536)]
        public void RaiseToPowerMethods(int x, double y, int p, double expResult)
        {
            var result = Class1.RaiseToPower(x, y, p);
            Assert.AreEqual(expResult, result);
        }
    }
}