using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstconsolerpg
{
    class Program
    {
        public static Player currentPlayer = new Player();
        static void Main(string[] args)
        {
            Story.TitleScreen();
            Story.Intro();
            Story.Part1();

            Console.ReadLine();
        }
    }
}
