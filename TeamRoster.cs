using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L12_Generic
{

    internal class TeamRoster<T> where T : Player// This says whatever is passed in has to be derived  from the Player class
    {
        // Use <T> to make your class generic, T represents the data type passed in
        // use where T : type to restrict what types can be passed in
        // restricting prevents users from passing in objects not from the derived type
        string _name;
        string _city;
        string _coach;
        string _stadium;
        string _cheerleader;
        List<T> _players;


        // ANother construtor that just takes city and name

        public TeamRoster(string name, string city)
        {
            _name = name;
            _city = city;
            _coach = "ME";
            _players = new List<T>();
        }


        public TeamRoster(string name, string city, string coach, string stadium, string cheerleader)
        {
            _name = name;
            _city = city;
            _coach = coach;
            _stadium = stadium;
            _cheerleader = cheerleader;
            _players = new List<T>();
        }

        // Default with preload()
        public TeamRoster()
        {
            _name = "Knights";
            _city = "Las Vegas";
            _coach = "That Guy";
            _stadium = "T-Mobile Arena";
            _players = new List<T>();
            //_players.Add(new Player());
            //_players.Add(new Player());
            //_players.Add(new Player());
            //_players.Add(new Player());
        }



        public string Name { get => _name; set => _name = value; }
        public string City { get => _city; set => _city = value; }
        public string Coach { get => _coach; set => _coach = value; }
        public string Stadium { get => _stadium; set => _stadium = value; }
        public string Cheerleader { get => _cheerleader; set => _cheerleader = value; }
        internal List<T> Players { get => _players; }

        public void AddPlayer(T player)
        {
            _players.Add(player);
        }

        // Display Team Info
        public void DisplayTeamInfo()
        {
            // Display team name
            // City
            // COach
            // Players

            Console.WriteLine($"{_city} {_name}");// Seattle Kraken
            Console.WriteLine($"Coach: {_coach}");// Coach: Whatever The Name

            // doing where T : Player
            // Means every T is Player

            // foreach Player player in _players
            foreach (T player in _players)
            {
                Console.WriteLine($"First Name: {player.FirstName}");
                Console.WriteLine($"Last Name: {player.LastName}");
                //Console.WriteLine(player);
            }
        } // Display Team Info

 
 


        // List of Players

        // Players
        // Coaches
        // Stadiums
        // Name
        // Cheerleaders / Mascot
        // City


        // Softball
        // Hockey
        // Soccer - Sounders
        // Baseball - Mariners
        // Football - Seahawks
        // BasketBall - Sonic - Storms
        // Kayak Polo - 



    }
}
