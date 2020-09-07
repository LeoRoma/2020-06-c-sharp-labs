using NUnit.Framework;
using CodingInterviewPractice;

namespace CodingInterviewPracticeTests
{
    class ArrayListDictionarySumTests
    {
        private ArrayListDictionarySum _testClass= new ArrayListDictionarySum();

        [TestCase(new int[] { 10, 11, 15, 25 }, -26)]
        [TestCase(new int[] { 1, 2, 3, 4 }, -35)]
        [TestCase(new int[] { 5, 6, 7, 8 }, -32)]
        public void SumOfNumbersArrayListDictionarySum(int[] inputArray, int result)
        {
            var actual = _testClass.TestArrayListDictionarySum(inputArray);
            Assert.AreEqual(result, actual);
        }
    }
}
