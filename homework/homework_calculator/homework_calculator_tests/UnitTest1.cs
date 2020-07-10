using NUnit.Framework;
using homework_calculator;

namespace homework_calculator_tests
{
    public class CalculatorTest
    {
        [SetUp]
        public void Setup()
        {
        }
        //Arrange
        [TestCase(1, 1, 2)]
        [TestCase(4, 4, 8)]
        [TestCase(30, 22, 52)]
        [TestCase(15, 15, 30)]
        public void TestingSum(int x, int y, int expectSum)
        {
            //Act
            var actual = Calculator.Add(x, y);
            //Assert
            Assert.AreEqual(expectSum, actual);
        }

        [TestCase(2, 1, 1)]
        [TestCase(4, 3, 1)]
        [TestCase(30, 22, 8)]
        [TestCase(40, 15, 25)]
        public void TestingSubstract(int x, int y, int expectSubstract)
        {
            var actual = Calculator.Substract(x, y);
            Assert.AreEqual(expectSubstract, actual);
        }

        [TestCase(1, 1, 1)]
        [TestCase(4, 4, 16)]
        [TestCase(30, 22, 660)]
        [TestCase(15, 15, 225)]
        public void TestingMultiply(int x, int y, int expectMult)
        {
            //Act
            var actual = Calculator.Multiply(x, y);
            //Assert
            Assert.AreEqual(expectMult, actual);
        }

        [TestCase(1, 1, 1)]
        [TestCase(4, 2, 2)]
        [TestCase(30, 15, 2)]
        [TestCase(500, 10, 50)]
        public void TestingDivide(int x, int y, int expectDivide)
        {
            //Act
            var actual = Calculator.Divide(x, y);
            //Assert
            Assert.AreEqual(expectDivide, actual);
        }

        [TestCase(1, 1, 0)]
        [TestCase(9, 4, 1)]
        [TestCase(6, 5, 1)]
        [TestCase(12, 7, 5)]
        [TestCase(10, 3, 1)]
        public void TestingModulus(int x, int y, int expectModulus)
        {
            //Act
            var actual = Calculator.Modulus(x, y);
            //Assert
            Assert.AreEqual(expectModulus, actual);
        }
    }
}