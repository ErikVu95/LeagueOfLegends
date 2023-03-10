using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegends
{
    public class Champion
    {
        public string Id { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string[] Tags { get; set; }
        public string Description { get; set; }
        public Stat Stats { get; set; }
        public List<Item> Items { get; set; } // Huske å implementere dette på et senere tidspunkt


    }
    public class Stat
    {
        public double Hp { get; set; }
        public double Hpperlevel { get; set; }
        public double Mp { get; set; }
        public double Mpperlevel { get; set; }
        public double Movespeed { get; set; }
        public double Armor { get; set; }
        public double Armorperlevel { get; set; }
        public double Spellblock { get; set; }
        public double Spellblockperlevel { get; set; }
        public double Attackrange { get; set; }
        public double Hpregen { get; set; }
        public double Hpregenperlevel { get; set; }
        public double Mpregen { get; set; }
        public double Mpregenperlevel { get; set; }
        public double Crit { get; set; }
        public double Critperlevel { get; set; }
        public double Attackdamage { get; set; }
        public double Attackdamageperlevel { get; set; }
        public double AttackspeedPerlevel { get; set; }
        public double Attackspeed { get; set; }
    }
}
