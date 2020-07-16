using NUnit.Framework;
using SafariPark;

namespace SafariParkTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("Cathy", "French", "Cathy French")]
        public void GetFullNameTest(string fName, string lName, string expected)
        {
            var instance = new Person(fName, lName);
            var actual = instance.GetFullName();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(25, 25)]
        public void GetAgeTest(int age, int expected)
        {
            Person person = new Person("Leo", "Xia") { Age = 25};

            
            Assert.AreEqual(expected, person.Age);
        }
    }
}