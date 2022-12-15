using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegends
{
    internal class Objective
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
        public int Damage { get; set; }

        public Objective(string name, int health, int armor, int damage)
        {
            
        }
    }
}
