using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClasses
{
    internal class Musician
    {
        //Fields
        string _name;
        string _stageName;
        int _bookingFee;
        string _genre;

        //Properties
        public string Name { get => _name; set => _name = value; }
        public string StageName { get => _stageName; set => _stageName = value; }
        public int BookingFee { get => _bookingFee; set => _bookingFee = value; }
        public string Genre { get => _genre; set => _genre = value; }

        //Constructor
        public Musician(string name, string stageName, int bookingFee, string genre)
        {
            _name = name;
            _stageName = stageName;
            _bookingFee = bookingFee;
            _genre = genre;
        }
    }
}
