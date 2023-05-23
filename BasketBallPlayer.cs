using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L12_Generic
{
    internal class BasketBallPlayer : Player
    {
        int _points;
        int _assists;
        int _rebounds;
        int _blocks;
        int _steals;
        int _turnovers;

        public BasketBallPlayer(string firstName, string lastName, string number, byte heightInCentimeters) : base(firstName, lastName, number, heightInCentimeters)
        {
        }

        public int Points { get => _points; set => _points = value; }
        public int Assists { get => _assists; set => _assists = value; }
        public int Rebounds { get => _rebounds; set => _rebounds = value; }
        public int Blocks { get => _blocks; set => _blocks = value; }
        public int Steals { get => _steals; set => _steals = value; }
        public int Turnovers { get => _turnovers; set => _turnovers = value; }
    } // BasketBall Player

} // namespace
