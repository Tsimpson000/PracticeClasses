using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClasses
{
    internal class Bike
    {
        //Fields
        string _brand;
        string _type;
        string _color;
        int _numberOfWheels;
        //Properties
        public string Brand { get => _brand; set => _brand = value; }
        public string Type { get => _type; set => _type = value; }
        public string Color { get => _color; set => _color = value; }
        public int NumberOfWheels { get => _numberOfWheels; set => _numberOfWheels = value; }
        //Constructor

        public Bike(string brand, string type, string color, int numberOfWheels)
        {
            _brand = brand;
            _type = type;
            _color = color;
            _numberOfWheels = numberOfWheels;
        }

    }
}
