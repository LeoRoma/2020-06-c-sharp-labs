using NUnit.Framework;
using CodingInterviewPractice;

namespace CodingInterviewPracticeTests
{
    class ArrayLoopsSumTests
    {
        private Loop _loop = new Loop();

        [TestCase(new int[] { 10, 11, 15, 25 }, 154)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 52)]
        [TestCase(new int[] { 5, 6, 7, 8 }, 84)]
        public void SumOfNumbersInLoop(int[] inputArray, int result)
        {
            var actual = _loop.TestArrayLoops(inputArray);
            Assert.AreEqual(result, actual);
        }
    }
}

