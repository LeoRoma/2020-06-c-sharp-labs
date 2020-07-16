using NUnit.Framework;
using SafariPark;
using System.Linq.Expressions;

namespace Airplane_Test
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Airplane a = new Airplane(200, 100, "JetRuss") { NumPassengers = 150 };
        }
    }
}