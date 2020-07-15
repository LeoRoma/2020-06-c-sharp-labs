using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.SymbolStore;

namespace SafariPark
{
    public class Vehicle
    {
        protected int _capacity;
        protected int _numPassengers;
        protected int _speed = 10;

        public int Position { get; set; }
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

        public virtual string Move()
        {
            Position += _speed; 
            return "Moving along";
        }

        public virtual string Move(int times)
        {
            Position += times * _speed;
            return $"Moving along {times} times";
        }

       
       public override string ToString()
        {
            return $"{base.ToString()} capacity: {_capacity} passengers: {_numPassengers} speed: {_speed} position: {Position}";
        }

    }
}
