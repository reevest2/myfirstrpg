using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstconsolerpg
{
    class Program
    {
       public static Player player = new Player("Hero", 25, 4);
        public static Monster monster = new Monster("MonStar", 15, 1);
        public static Monster monster1 = new Monster("Monstar1", 30, 1);
        static void Main(string[] args)
        {
            Story.TitleScreen();
            Story.Intro();
            Story.Part1();

            player.DisplayStats();
            Console.WriteLine();
            monster.DisplayStats();
            player.Slash(monster);
            Console.WriteLine("You used Slash");
            Console.ReadLine();

            player.DisplayStats();
            Console.WriteLine();
            monster.DisplayStats();
            player.Slash(monster);
            Console.WriteLine("You used Slash");
            Console.ReadLine();

            player.DisplayStats();
            Console.WriteLine();
            monster.DisplayStats();
            player.Slash(monster);
            Console.WriteLine("You used Slash");
            Console.ReadLine();

            player.DisplayStats();
            Console.WriteLine();
            monster.DisplayStats();
            player.Slash(monster);
            Console.WriteLine("You used Slash");
            Console.ReadLine();

            player.DisplayStats();
            Console.WriteLine();
            monster.DisplayStats();
            player.Slash(monster);
            Console.WriteLine("You used Slash");
            Console.ReadLine();

            player.DisplayStats();
            Console.WriteLine();
            monster1.DisplayStats();
            player.Slash(monster1);
            Console.WriteLine("You used Slash");
            Console.ReadLine();

            player.DisplayStats();
            Console.WriteLine();
            monster1.DisplayStats();
            player.Slash(monster1);
            Console.WriteLine("You used Slash");
            Console.ReadLine();

            player.DisplayStats();
            Console.WriteLine();
            monster1.DisplayStats();
            player.Slash(monster1);
            Console.WriteLine("You used Slash");
            Console.ReadLine();

            player.DisplayStats();
            Console.WriteLine();
            monster1.DisplayStats();
            player.Slash(monster1);
            Console.WriteLine("You used Slash");
            Console.ReadLine();




        }
    }
}
