using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L12_Generic
{
    internal class ESportsPlayer : Player
    {
        int _wins;
        int _losses;
        int _bossKills;
        string _mainCharacter;

        public ESportsPlayer(int wins, int losses, int bossKills, string mainCharacter)
        {
            _wins = wins;
            _losses = losses;
            _bossKills = bossKills;
            _mainCharacter = mainCharacter;
        }

        public ESportsPlayer(string firstName, string lastName, string number, byte heightInCentimeters) : base(firstName, lastName, number, heightInCentimeters)
        {
        }

        public int Wins { get => _wins; set => _wins = value; }
        public int Losses { get => _losses; set => _losses = value; }
        public int BossKills { get => _bossKills; set => _bossKills = value; }
        public string MainCharacter { get => _mainCharacter; set => _mainCharacter = value; }
    }
}
