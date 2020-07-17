using System;

namespace RadioApp
{
    public class Radio
    {
        private int _channel = 1;
        private bool _on;

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
    }
    // implement a class Radio that corresponds to the Class diagram 
    //   and specification in the Radio_Mini_Project document
}