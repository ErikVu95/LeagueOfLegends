using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegends
{
    internal class PreIngameInfo
    {
        readonly Random _random = new();
        private readonly List<string> _facts = new();

        public PreIngameInfo()
        {
            AddFacts();
        }

        public void Menu(Team blueTeam, Team redTeam)
        {
            Console.Clear();
            while (true)
            {
                PrintTeams(blueTeam);
                PrintTeams(redTeam);
                Menu();

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Clear();
                        return;

                    case "2":
                        Console.WriteLine(RandomFacts());
                        Console.ReadLine();
                        break;

                    case "3":
                        Environment.Exit(0);
                        break;
                        
                    default:
                        Console.Clear();
                        Console.WriteLine("Type in a valid number.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        private string RandomFacts()
        {
            return _facts[_random.Next(0, _facts.Count)];
        }

        private void PrintTeams(Team team)
        {
            Console.WriteLine($"{team.Name}:");
            foreach (var champinfo in team.Champions)
            {
                Console.WriteLine($"{champinfo.Name}. Title: {champinfo.Title}.");
                Console.WriteLine($"Health: {champinfo.Stats.Hp}, " +
                                  $"Attack Damage: {champinfo.Stats.Attackdamage}, " +
                                  $"Movespeed: {champinfo.Stats.Movespeed}, " +
                                  $"armor: {champinfo.Stats.Armor}\n ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        private void Menu()
        {
            Console.WriteLine("1. Play");
            Console.WriteLine("2. Random League fact");
            Console.WriteLine("3. Exit the application");
        }

        private void AddFacts()
        {
            //Kanskje lage en json for dette
            _facts.Add(("When more than one ninja champion is in the same team, they lose 1 health."));
            _facts.Add(("When Sion kills Zyra and vice versa, they get 2 bonus gold."));
            _facts.Add(("Malphite’s ground slam leaves Riot Games logo on the ground."));
            _facts.Add(("Maokai is an anagram of I am oak."));
            _facts.Add(("Maokai and Zyra get 1 movement speed when they are near each other."));
            _facts.Add(("When Zilean and Volibear are on 2 separate teams, Volibear gets the chronokeeper hater buff and Zilean gets the armoured bear hater buff."));
            _facts.Add(("If you walk into a bush as Skarner and wait for a bit, he will say “Skar Skar Skarner” as a reference to Pokemon."));
            _facts.Add(("If Jinx or Vi perform their special taunt on Caitlyn, she’ll get the debuff “Agitated”."));
            _facts.Add(("Whenever Jinx is on an opposing team to Caitlyn and/or Vi, they each get a debuff titled “catch me if you can”."));
            _facts.Add(("When Vi and Caitlyn score a kill together, they receive 1 extra gold."));
            _facts.Add(("Leona does 1 less damage with her Sunlight to champions with sunglasses."));
            _facts.Add(("If two Draven’s are dueling, they can catch each other’s axes."));
            _facts.Add(("Sejuani’s dash can break Jarvan’s ultimate (as in actually break the wall)."));
            _facts.Add(("When an enemy Nunu dies near Thresh, two souls drop, one for Nunu and other for Willump (the yeti)."));
            _facts.Add(("Volibear’s Rolling Thunder allows him to move enemy wards if he can see and target them."));
            _facts.Add(("If Fizz does a killing blow to a small champion with his ultimate, the dead champion corpse will disappear (the shark eats the body)."));
            _facts.Add(("There’s a smiley face on a rock at the bottom lane."));
            _facts.Add(("The first champion designed was Singed."));
            _facts.Add(("Vi stands for the Roman numeral 6, because she was the 106th champion."));
            _facts.Add(("Scoring a pentakill with Heimerdinger will grant a cosmetic buff “Eureka”."));
        }
    }
}
