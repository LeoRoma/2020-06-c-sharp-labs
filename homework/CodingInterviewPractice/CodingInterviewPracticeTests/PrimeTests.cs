using NUnit.Framework;
using CodingInterviewPractice;

namespace CodingInterviewPracticeTests
{
    public class Tests
    {
        private Prime _prime = new Prime();

        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 18)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 }, 42)]
        [TestCase(new int[] { 10, 11, 12, 13, 14, 15, 16, 17 }, 41)]
        [TestCase(new int[] { 19, 20, 21, 23 }, 42)]
        public void SumOfPrimeNumbers(int[] inputArray, int result)
        {
            var actual = _prime.SumOfPrime(inputArray);
         
            Assert.AreEqual(result, actual);
        }

        [TestCase(7, 7)]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(5, 5)]
        [TestCase(7, 7)]
        [TestCase(11, 11)]
        public void GetPrimeNumberToSum(int num, int result)
        {
            var actual = _prime.GetPrime(num);
            Assert.AreEqual(result, actual);
        }
    }
}