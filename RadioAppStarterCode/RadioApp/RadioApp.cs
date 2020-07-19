using System;

namespace RadioApp
{
    public class Radio
    {
        private int _channel = 1;
        public bool _on;
        private const int _defaultVolume = 30;
        private const int _maxVolume = 100;
        private const int _minVolume = 0;
        private int _volume = _defaultVolume;

        public int Channel 
        {
            get { return _channel; }  
            set { if (value > 0 && value <= 4 && _on == true) _channel = value; }
        }

        public Radio()
        {

        }

        public string Play()
        {
            if (_on == true)
            {
                return $"Playing channel {_channel}";
            }
            return "Radio is off";
            
        }

        public void TurnOff()
        {
            _on = false;
            Console.WriteLine("Radio is off");
        }

        public void TurnOn()
        {
            _on = true;
        }

        public int IncreaseVolume()
        {
            if (_volume > _maxVolume)
            {
                throw new Exception("Cannot increase the volume over 100.");
            }
            _volume += 1;
            return _volume;
        }

        public int DecreaseVolume()
        {
            if (_volume < _minVolume)
            {
                throw new Exception("Cannot decrease the volume less than 0.");
            }
            _volume -= 1;
            return _volume;
        }
    }
    // implement a class Radio that corresponds to the Class diagram 
    //   and specification in the Radio_Mini_Project document
}