using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    class Airplane : Vehicle
    {
        private string _airline;
        private int _altitude;
        public Airplane(int capacity, int speed, string airline) : base(capacity, speed)
        {
            _airline = airline;
        }
        public void Ascend(int distance)
        {
            _altitude = distance;
        }

        public void Descend(int distance)
        {
            _altitude = distance + _speed;
        }

        public override string Move()
        {
            Position += _speed;
            return $"Moving along at an altitude of {_altitude} metres.";
        }

        public override string Move(int times)
        {
            Position += times * _speed;
            
            return $"Moving along {times} times at an altitude of {_altitude} metres.";
            
        }

        public override string ToString()
        {
            return $"Thank you for flying {_airline}: {base.ToString()} altitude: {_altitude}.";
        }
    }
}
