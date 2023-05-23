using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L12_Generic
{
    internal class Player : IComparable<Player>
    {
        // first name
        // last name
        // number
        // height

        string _firstName;
        string _lastName;
        string _number;
        byte _heightInCentimeters;

        public Player()
        {
            _firstName = "Shea";
            _lastName = "Theodore";
            _heightInCentimeters = 185;
            _number = "27";
        }

        public Player(string firstName, string lastName, string number, byte heightInCentimeters)
        {
            _firstName = firstName;
            _lastName = lastName;
            _number = number;
            _heightInCentimeters = heightInCentimeters;
        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Number { get => _number; set => _number = value; }
        public byte HeightInCentimeters { get => _heightInCentimeters; set => _heightInCentimeters = value; }

        public int CompareTo(Player? other)
        {
            return _firstName.CompareTo(other._firstName);
        }

        public override string ToString()
        {
            // First Name Last Name - Number - Height
            return $"{_firstName} {_lastName} - Number:  {_number} - Height: {_heightInCentimeters}";
        }

    } // 
}
