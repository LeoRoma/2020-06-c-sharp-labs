using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public class Vehicle
    {
        private int _capacity;
        private int _numPassengers;
        private int _speed = 10;

        public int Position { get; private set; }
        public int NumPassengers 
        {
            get { return _numPassengers; }
            set
            {
                if (value >= 0 && value <= _capacity)
                {
                    _numPassengers = value;
                }
                else if (value > _capacity)
                {
                    _numPassengers = _capacity;
                }
            }
        }

        public Vehicle(int capacity = 6, int speed = 10)
        {
            _capacity = capacity;
            _speed = speed;
        }
        public Vehicle()
        {
           
        }

        public string Move()
        {
            Position += _speed; 
            return "Moving along";
        }

        public string Move(int times)
        {
            Position += times * _speed;
            return $"Moving along {times} times";
        }


    }
}
