﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    //Class is a reference type of data type, can store more data.
    public class Person
    {
        //Attributes or Fields
        private string _firstName; //Private can be accessed only by this class 
        private string _lastName;
        private int _age;

        //Encapsulation
        //Property -> a method that can get and set a value; get = read, set = write
        //We can use Property as method
        //Getter and setter to set private variables
        public int Age
        {
            get { return _age; }
            set { if (value >= 0) _age = value; }
        }

        //Constructor must have the same name as the class --> doesn't return a value
        //ctor -> shortcut to create a constructor
        //As for a method we can overload contructors and set a default parameter
        public Person(string fName, string lName)
        {
            _firstName = fName;
            _lastName = lName;
        }

        //public Person(string fName, string lName, int age)
        //{
        //    _firstName = fName;
        //    _lastName = lName;
        //    _age = age;
        //}

        public Person()
        {

        }
        public string GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }

        public override string ToString()
        {
            return $"{base.ToString()} Name: {GetFullName()}  Age: {Age}";
        }
    }
}
