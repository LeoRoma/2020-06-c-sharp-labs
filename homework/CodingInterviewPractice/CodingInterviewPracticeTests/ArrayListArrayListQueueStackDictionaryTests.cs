using NUnit.Framework;
using CodingInterviewPractice;

namespace CodingInterviewPracticeTests
{
    class ArrayListArrayListQueueStackDictionaryTests
    {
        private ArraylistArrayListQueueStackDictionarySum _testClass = new ArraylistArrayListQueueStackDictionarySum();

        [TestCase(new int[] { 1, 1, 1, 1 }, 4096)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 10240)]
        [TestCase(new int[] { 5, 6, 7, 8 }, 26624)]
        public void SumOfNumbersArrayListDictionarySum(int[] inputArray, int result)
        {
            var actual = _testClass.TestArrayListArrayListQueueStackDictionarySum(inputArray);
            Assert.AreEqual(result, actual);
        }
    }
}
