using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegends
{
    internal class Team
    {
        public string Name { get; set; }
        public List<Champion> Champions { get; set; }
        public List<Objective> Objectives { get; set; }

        public Team(string name)
        {
            Name = name;
            Champions = new List<Champion>();
            Objectives = new List<Objective>();
        }
    }
}
