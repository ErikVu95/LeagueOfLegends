using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegends
{
    internal class CreateTeamMenu
    {
        //Ikke optimalt sted å holde på lagene her, men OK for nå.
        public TeamCreator TeamCreator = new();
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("Would you like to create your own team, or have your team made for you?");
            Console.WriteLine("1. Create your own team\n2. Autofilled team\n3. Exit");

            var onGoing = true;
            while (onGoing)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        TeamCreator.CreateBlueTeam();
                        onGoing = false;
                        break;

                    case "2":
                        TeamCreator.AutoFillBothTeams();
                        onGoing = false;
                        break;

                    case "3":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Type in a valid number.");
                        break;
                }
            }
        }
    }
}
