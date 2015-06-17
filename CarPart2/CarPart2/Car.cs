using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPart2
{
    class Car
    {
        private string _colour;
        private string _make;
        private int _year;


        public Car(string color, string make, int year)
        {
            this._colour = color;
            this._make = make;
            this._year = year;
        }

        public Car()
        {

        }

        public string Describe()
        {
            return "This car is " + Colour;
        }

        public string Colour
        {
            get { return _colour; }
            set { _colour = value; }
        }

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

    }
}
