using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstconsolerpg
{
    class Program
    {
        public static Player player = new Player("Hero", 25, 5, 2);
        public static Monster monster = new Monster("Monster", 15, 1, 1);
        public static Monster monster1 = new Monster("Evil Voice", 30, 1, 1);
        static void Main(string[] args)
        {
           // Story.TitleScreen();
           // Story.Intro();
           // Story.Part1();
            Battle.startBattle(player, monster);
            Console.WriteLine($"You beat { monster.name }");
            Console.ReadLine();
            Console.WriteLine($"{monster1.name} appears. Prepare for another battle");
            Console.ReadLine();
            Battle.startBattle(player, monster1);
            Console.WriteLine($"You beat { monster1.name }");
            Console.ReadLine();
            Console.WriteLine("You beat the Evil Voice and also the game!");
            Console.ReadLine();


        }
    }
}
