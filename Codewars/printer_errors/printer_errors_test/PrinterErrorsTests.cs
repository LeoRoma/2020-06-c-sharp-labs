using NUnit.Framework;
using printer_errors;

namespace printer_errors_test
{
    public class Tests
    {
        private PrinterErrors _printerErrors = new PrinterErrors();
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("a", "0/1")]
        [TestCase("aaa", "0/3")]
        [TestCase("aaaaz", "1/5")]
        [TestCase("aaaaaaaamnytr", "4/13")]
        [TestCase("aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz", "3/56")]
        public void PrinterError(string s, string expected)
        {
            var actual = _printerErrors.PrinterError(s);
         
            Assert.Pass(expected, actual);
        }
    }
}