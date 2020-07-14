﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public class Vehicle
    {
        private int _capacity;
        private int _numPassengers;
        private int _speed;

        public int Position { get; set; }
        public int NumPassangers { get; set; }

        public Vehicle(int capacity, int speed = 10)
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
            Position += times * 10;
            return "Moving along 2 times";
        }


    }
}
