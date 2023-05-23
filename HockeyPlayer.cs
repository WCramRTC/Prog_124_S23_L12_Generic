using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L12_Generic
{
    internal class HockeyPlayer : Player
    {
        int _gamesPlayed;
        int _goals;
        int _assists;
        int _points;

        public HockeyPlayer(int gamesPlayed, int goals, int assists, int points)
        {
            _gamesPlayed = gamesPlayed;
            _goals = goals;
            _assists = assists;
            _points = points;
        }

        public HockeyPlayer(string firstName, string lastName, string number, byte heightInCentimeters) : base(firstName, lastName, number, heightInCentimeters)
        {
        }

        public int GamesPlayed { get => _gamesPlayed; set => _gamesPlayed = value; }
        public int Goals { get => _goals; set => _goals = value; }
        public int Assists { get => _assists; set => _assists = value; }
        public int Points { get => _points; set => _points = value; }
    }
}
