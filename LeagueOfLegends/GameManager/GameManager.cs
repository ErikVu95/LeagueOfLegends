using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegends
{
    internal class GameManager
    {
        public Menu Menu = new();
        public CreateTeamMenu CreateTeamMenu = new();
        public PreIngameInfo PreIngameInfo = new();
        public Team BlueTeam => CreateTeamMenu.TeamCreator.BlueTeam;
        public Team RedTeam => CreateTeamMenu.TeamCreator.RedTeam;

        public IngameSR IngameSR;

        public GameManager() //Initializing order via Program
        {
            Menu.ShowMenu();
            CreateTeamMenu.Menu();
            PreIngameInfo.Menu(BlueTeam, RedTeam);
            IngameSR = new IngameSR(BlueTeam, RedTeam);
        }
    }
}
