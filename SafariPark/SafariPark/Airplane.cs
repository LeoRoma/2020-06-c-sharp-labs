using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public class Airplane : Vehicle
    {
        private string _airline;
        private int _altitude;

        public Airplane(int capacity, int speed, string airline) : base(capacity, speed)
        {
            _airline = airline;
        }

        public Airplane(int capacity) : base(capacity)
        {
            
        }

        public void Ascend(int distance)
        {
            _altitude += distance;
        }

        public void Descend(int distance)
        {
            if (_altitude > distance) _altitude -= distance;
            else _altitude = 0;
        }

        public override string Move()
        {
            Position += _speed;
            return $"{base.Move()} at an altitude of {_altitude} metres.";
        }

        public override string Move(int times)
        {
            Position += times * _speed;
            
            return $"{base.Move(times)} times at an altitude of {_altitude} metres.";
            
        }

        public override string ToString()
        {
            return $"Thank you for flying {_airline}: {base.ToString()} altitude: {_altitude}.";
        }
    }
}
