using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
//using System.Text.Json;

namespace LeagueOfLegends
{
    internal class TeamCreator
    {
        static readonly string FileName = "champions.json"; 
        private readonly string _jsonFile = File.ReadAllText(FileName);
        public List<Champion> Champions = new();

        public Team BlueTeam = new("Blue Team");
        public Team RedTeam = new("Red Team");

        private Random _random = new();
        public TeamCreator()
        {
            //Champions = JsonSerializer.Deserialize<List<Champion>>(_jsonFile);
            Champions = JsonConvert.DeserializeObject<List<Champion>>(_jsonFile);
            AddObjectivesToTeam(BlueTeam);
            AddObjectivesToTeam(RedTeam);
        }

        public void AddObjectivesToTeam(Team team)
        //Separere denne senere for å skille mellom ARAM og SR. Kalle dem AddAramObjectivesToTeam() og AddSrObjectivesToTeam()
        {
            team.Objectives.Add(new Turret());
            team.Objectives.Add(new Turret());
            team.Objectives.Add(new Turret());
            team.Objectives.Add(new Inhibitor());
            team.Objectives.Add(new Nexus());
        }

        public void AddChampionToBlueTeam()
        {
            while (true)
            {
                string nameFromUserInput = Console.ReadLine().ToLower();

                foreach (var champion in Champions)
                {
                    if (nameFromUserInput.Contains(champion.Id) && !BlueTeam.Champions.Contains(champion))
                    {
                        BlueTeam.Champions.Add(champion);
                        Console.WriteLine($"{champion.Name} has successfully been added to your team.");
                        return;
                    }
                }
                Console.WriteLine("The champion already exists or there was a typo. Try again.");
            }
        }

        public void AddChampionAutofillTeam(Team team)
        {
            while (true)
            {
                var GetRandomChamp = ReturnRandomChampion();

                if (!team.Champions.Contains(GetRandomChamp))
                {
                    team.Champions.Add(GetRandomChamp);
                    return;
                }
            }
        }

        public void CreateBlueTeam()
        {
            PrintAllChamps();
            Console.WriteLine("\nChoose five champions for your team.\n");

            for (int teamCount = 0; teamCount < 5; teamCount++)
            {
                AddChampionToBlueTeam();
            }
            Console.WriteLine();
            Console.WriteLine();
            CreateAutofilledTeam(RedTeam);
        }

        public void CreateAutofilledTeam(Team team)
        {
            for (int teamCount = 0; teamCount < 5; teamCount++)
            {
                AddChampionAutofillTeam(team);
            }
        }

        public void AutoFillBothTeams()
        {
            CreateAutofilledTeam(BlueTeam);
            CreateAutofilledTeam(RedTeam);
        }

        public void PrintAllChamps()
        {
            int number = 1;
            int newLine = 0;
            foreach (var name in Champions)
            {
                Console.Write($"{number}. " + $"{name.Name} ");
                number++;
                newLine++;

                if (newLine == 5)
                {
                    Console.WriteLine();
                    newLine = 0;
                }
            }
        }

        public Champion ReturnRandomChampion()
        {
            return Champions[_random.Next(0, Champions.Count)];
        }
    }
}


//public void test()
//{
//    foreach (var q in BlueTeam.Champions)
//    {
//        Console.WriteLine($"BlueTeam Name: {q.Name}");
//    }

//    foreach (var q in RedTeam.Champions)
//    {
//        Console.WriteLine($"RedTeam Name: {q.Name}");
//    }
//}


//public void test()
//{
//    var q = Champions
//        .OrderBy(g => g.Key);

//    foreach (var num in q)
//    {
//        Console.WriteLine(num.Key);
//    }
//}