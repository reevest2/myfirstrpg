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
               
                AddTurnSpeed(player, monster);
                if (player.speed >= 3)
                {
                    //player inputs their move.
                    player.yourturn(player.Choice(),monster);
                    player.speed -= 3;
                    DisplayHealthRemaining(monster);
                    Console.WriteLine("=====================");
                }
                else if (monster.speed >= 4)
                {
                    monster.Slash(player);
                    monster.speed -= 4;
                    DisplayHealthRemaining(player);
                    Console.WriteLine("=====================");
                }
                else
                {
                    Console.WriteLine($"{ player.name}  {player.speed}");
                    Console.WriteLine($"{ monster.name}  {monster.speed}");
                    DisplayTheStats(player, monster);
                    Console.WriteLine("=====================");
                    Console.ReadLine();
                }

            }
        }


    }
}



