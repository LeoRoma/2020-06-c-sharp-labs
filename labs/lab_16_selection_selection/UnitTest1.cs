using NUnit.Framework;
using lab_16_selection;

namespace lab_16_selection_selection
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Mark40AndOverPasses()
        {
            var result = Selection.PassFail(41);
            Assert.AreEqual("Pass", result);
        }

        [Test]
        public void Mark39AndUnderPasses()
        {
            var result = Selection.PassFail(38);
            Assert.AreEqual("Fail", result);
        }

        [Test]
        public void Mark100AndUnderDistinct()
        {
            var result = Selection.PassFail(76);
            Assert.AreEqual("Distinction", result);
        }


        [Test]
        public void TestLevel3()
        {
            var result = Selection.PassFail(76);
            Assert.AreEqual("Distinction", result);
        }

        [Test]
        public void TestLevel2()
        {
            var result = Selection.PassFail(76);
            Assert.AreEqual("Distinction", result);
        }

        [Test]
        public void TestLevel1()
        {
            var result = Selection.PassFail(76);
            Assert.AreEqual("Distinction", result);
        }

        [Test]
        public void TestLevelDefault()
        {
            var result = Selection.PassFail(76);
            Assert.AreEqual("Distinction", result);
        }
    }
}