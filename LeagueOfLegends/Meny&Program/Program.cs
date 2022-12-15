namespace LeagueOfLegends
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gameManager = new GameManager();
        }
    }
}



/* Meny for å ha en switch case for å velge mellom ARAM eller SUMMONERS RIFT. Man skal kunne velge fem karakterer ut som ender i en liste, for å ha som sitt eget lag. Enemy team blir random.Next og 5 Add's i enemy liste.
   
Class: 
AramManager og CreateTeamMenu

Menu: Printe menyer og så vil klassene over manage selve spillet.
CreateTeam()

Champion: Ta inn JSON fil og eventuelt ha lister her med champions.

TeamCreator
CreateTeam sin liste.

Objective?/Boss(Baron, dragon, turrets, inhibitor, nexus)
Når et team får sjansen til å gjøre baron, så skal det være random systemet til CSGO oppgaven for enemy team å interrupte.
                                                                                                                                        public static bool IsSuccessful(int maxValue)
                                                                                                                                                {
                                                                                                                                                    Random rand = new Random();

                                                                                                                                                    return rand.Next(0, maxValue) == 2;
                                                                                                                                                }


Item:

Mulighet for å kjøpe items for å increase damage eller health. Usikker på om hver karakter skal ha items eller at hele laget får en buff.

SpacebarSkip


*/
