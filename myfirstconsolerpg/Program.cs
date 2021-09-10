using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstconsolerpg
{
    class Program
    {
       public static Player Hero = new Player("Hero", 25, 4);
        static void Main(string[] args)
        {
            Story.TitleScreen();
            Story.Intro();
            Story.Part1();
            
            Console.ReadLine();

        }
    }
}
