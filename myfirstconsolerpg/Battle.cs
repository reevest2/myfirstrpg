using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstconsolerpg
{
    class Battle
    {
        public static void DisplayTheStats(Character character1, Character character2)
        {
            character1.DisplayStats();
            Console.WriteLine(" ");
            character2.DisplayStats();
            Console.WriteLine(" ");
        }

        public static void DisplayHealthRemaining(Character character1)
        {
            character1.HealthRemaining();
            Console.WriteLine(" ");
        }

        public static void AddTurnSpeed(Character character1, Character character2) 
        {
            character1.speed += 1;
            character2.speed += 1;
        }


        public static void startBattle(Player player, Monster monster)
        {
            DisplayTheStats(player, monster);
            Console.ReadLine();
            while ( player.health > 0 && monster.health > 0)

            {
                Console.WriteLine("characters are waiting for their turn.");
                Console.ReadLine();
                AddTurnSpeed(player, monster);
                if (player.speed >= 3)
                {
                    //will change this to be a choice input later. working on turns now. need to balance but logic is there i think.
                    player.Slash(monster);
                    player.speed -= 3;
                    DisplayHealthRemaining(monster);
                }
                else if (monster.speed >= 4)
                {
                    monster.Slash(player);
                    monster.speed -= 4;
                    DisplayHealthRemaining(player);
                }

            }
        }


    }
}



