using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegends
{
    public class Menu
    {
        public void ShowMenu()
        {
           // var AramManager = new AramManager();                           Skille disse på en eller annen måte senere
           // var createTeamManager = new CreateTeamMenu();

            Console.WriteLine("Welcome to League of Legends.");
            Console.WriteLine("Choose a gamemode:");
            Console.WriteLine("1. Play a game of ARAM.\n2. Play a game of Summoners Rift.\n3. Exit.");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("ARAM");
                    break;

                case "2":
                    Console.WriteLine("SR");
                    break;

                default:
                    Console.WriteLine("Good bye.");
                    break;
            }
        }
    }
}
