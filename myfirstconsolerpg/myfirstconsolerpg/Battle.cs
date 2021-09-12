using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstconsolerpg
{
    class Battle
    {
        public static void DisplayTheStats (Character character1, Character character2)
        {
            character1.DisplayStats();
            Console.WriteLine(" ");
            character2.DisplayStats();
            Console.WriteLine(" ");
                }
        

        public static void startBattle(Player player, Monster monster)
        {
            while ( player.health > 0 && monster.health > 0)
            {
                DisplayTheStats(player, monster);
                player.Slash(monster);
                monster.Slash(player);

            }
        }


    }
}



