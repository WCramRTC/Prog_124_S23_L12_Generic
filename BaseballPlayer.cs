using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L12_Generic
{
    internal class BaseballPlayer : Player
    {
        int _winsAboveReplacment;
        int _hits;
        int _homeruns;
        int _atBat;
        int _stolenBases;

        public BaseballPlayer(string firstName, string lastName, string number, byte heightInCentimeters) : base(firstName, lastName, number, heightInCentimeters)
        {
        }

        public BaseballPlayer(int winsAboveReplacment, int hits, int homeruns, int atBat, int stolenBases)
        {
            _winsAboveReplacment = winsAboveReplacment;
            _hits = hits;
            _homeruns = homeruns;
            _atBat = atBat;
            _stolenBases = stolenBases;
        }

        public int WinsAboveReplacment { get => _winsAboveReplacment; set => _winsAboveReplacment = value; }
        public int Hits { get => _hits; set => _hits = value; }
        public int Homeruns { get => _homeruns; set => _homeruns = value; }
        public int AtBat { get => _atBat; set => _atBat = value; }
        public int StolenBases { get => _stolenBases; set => _stolenBases = value; }
    }
}
