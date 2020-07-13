using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using lab_15_unit_test;

namespace lab_15_unit_test_tests
{
    public class Tests
    {
        private int _result;
        private int _sum;

        [SetUp]
        public void Setup()
        {
          
        }

        //Arrange
        [TestCase(10, 2, 4, 80)]
        [TestCase(5, 2, 2, 20)]
        [TestCase(0, 2, 4, 0)] // TestCase takes active Arguments
        public void ProductIsCorrect(int a, int b, int c, int expected)
        {
            //Act
            var actual = Calc.TripleCalc(a, b, c, out int sum);
            //Assert
            Assert.AreEqual(expected, actual); ; 
        }

        [TestCase(2, 2, 2, 6)]
        public void SumIsCorrect(int a, int b, int c, int expectedSum)
        {
            Calc.TripleCalc(a, b, c, out int sum);
            Assert.AreEqual(expectedSum, sum); 
        }
    }
}