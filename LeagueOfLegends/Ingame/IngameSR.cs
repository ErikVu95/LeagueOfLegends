using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegends
{
     class IngameSR
    {
        private Team BlueTeam;
        private Team RedTeam;
        private BaronNashor _baron = new();
        private Dragon _dragon = new();
        private Random _random = new Random();

        public IngameSR(Team blueTeam, Team redTeam)
        {
            BlueTeam = blueTeam;
            RedTeam = redTeam;
            Game();
        }

        private void Game()
        {
            while (true)
            {
                var blueAttackAmount = _random.Next(1, 6);
                var redAttackAmount = _random.Next(1, 6);
                Console.WriteLine(BlueTeam.Champions.Count);
                Console.WriteLine(RedTeam.Champions.Count);
                for (int i = 0; i < blueAttackAmount; i++)
                {
                    Fight(RedTeam);
                }

                for (int i = 0; i < redAttackAmount; i++)
                {
                    Fight(BlueTeam);
                }

                Console.ReadLine();
            }
        }

        private void Fight(Team opponent)
        {
            var randomcheck = _random.Next(1, 3); // En sjekk for spiller eller objective, sjanse IsSuccessful og damagedeal

            if (randomcheck == 1)
            {
              //  HitChampion(opponent);
              foreach (var q in opponent.Objectives)
              {
                  Console.WriteLine(q.Name);
              }
            }

            if (randomcheck == 2)
            {
                //  HitObjective(opponent);
                foreach (var q in opponent.Objectives)
                {
                    Console.WriteLine(q.Name);
                }

            }


        }

        private void HitChampion(Team team)
        {
            var randomChampionTarget = _random.Next(0, 6);

            Console.WriteLine("asd");
            Console.WriteLine(team.Champions[randomChampionTarget].Name);
        }

        private void HitObjective(Team team)
        {
          //  var randomObjectiveTarget = team.Objectives.Count - 1;

            foreach (var q in team.Objectives)
            {
                Console.WriteLine(q.Name);
            }
            
        }
        
        private void BaronFight(Team team)
        {

        }

        private void DragonFight(Team team)
        {

        }

        private bool IsSuccessful(int value)
        {
            Random _rand = new Random();

            return _rand.Next(0, value) == 2;
        }
    }
}
