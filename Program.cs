namespace Prog_124_S23_L12_Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test to make sure player works
            TeamRoster<HockeyPlayer> knights = new TeamRoster<HockeyPlayer>();

            //knights.DisplayTeamInfo();

            TeamRoster<BaseballPlayer> mariners = new TeamRoster<BaseballPlayer>("Mariners", "Seattle");      
            mariners.AddPlayer(new BaseballPlayer("Ichiro", "Suzuki", "51", 190));
            mariners.AddPlayer(new BaseballPlayer("Edgar", "Martinez", "11", 190));
            mariners.Players.Sort();
            mariners.DisplayTeamInfo();

            //TeamRoster<Player> thePlayers = new TeamRoster<Player>();
            //TeamRoster<ESportsPlayer> theEPlayers = new TeamRoster<ESportsPlayer>();


        } // Main

        public static void DisplayTeamInfo<T>(T teamInfo) where T : TeamRoster<HockeyPlayer>
        {
            teamInfo.DisplayTeamInfo();
        }

        public static void GenericExplination()
        {
            // Generic
            List<string> names = new List<string>();
            List<int> ages = new List<int>();

            Object obj1 = 1;
            Object obj2 = "Will";
            Object obj3 = true;

            List<object> objs = new List<object>();
            objs.Add("Will");
            objs.Add(1);
            objs.Add(true);
        }

    } // class

} // namespace