using NUnit.Framework;
using RadioApp;
using System;


namespace RadioTests
{
    class RadioVolumeTests
    {
        private Radio _radio;
        [SetUp]
        public void Setup()
        {
            _radio = new Radio();
            _radio.TurnOn();
        }

        [TestCase(31)]
        
        public void IncreaseVolumeTest(int increasedVolume)
        {
            
            Assert.AreEqual(increasedVolume, _radio.IncreaseVolume());
        }

        [Test]
        public void IncreaseVolumeOverThan100Test()
        {
            for (int i = 1; i < 71; i++)
            {
                _radio.IncreaseVolume();
            }

            Assert.AreEqual(101, _radio.IncreaseVolume());
            var ex = Assert.Throws<Exception>(() => _radio.IncreaseVolume());
            //Assert.AreEqual("Cannot increase the volume over 100.", ex.Message);
            //Assert.AreEqual("Can not increase volume over 100.");
        }

        [TestCase(29)]

        public void DecreaseVolumeTest(int decreasedVolume)
        {

            Assert.AreEqual(decreasedVolume, _radio.DecreaseVolume());
        }

        [Test]
        public void DecreaseVolumeLessThan0Test()
        {
            for (int i = 1; i < 31; i++)
            {
                _radio.DecreaseVolume();
            }

            Assert.AreEqual(-1, _radio.DecreaseVolume());
            var ex = Assert.Throws<Exception>(() => _radio.DecreaseVolume());
            //Assert.AreEqual("Cannot increase the volume over 100.", ex.Message);
            //Assert.AreEqual("Can not increase volume over 100.");
        }
    }
}
