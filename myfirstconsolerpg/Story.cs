using System;
using System.Threading;

namespace myfirstconsolerpg
{
     static class Global
    {
       public static int x = 75;
       //public static string playerName = string.Empty;
    }
    
    public class Story
        
    {
    
        public static void TitleScreen()
            
        {
                 
            string startText = @"
 ___________________________________________ 
||~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|
||  ###### ########   #### #######  ########|
|| ###  ## #  ###    #####  ###  ## #  ###  |
|| ####       ###   ## ###  ###  ##    ###  |
||  #####     ###  ##  ###  ######     ###  |
||    ####    ### ########  ### ##     ###  |
|| ##  ###    ### ##   ###  ###  ##    ###  |
||  #####     ### ##   ###  ###  ##    ###  |
||                 ###            ##        |
||__________________________________________|
 ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~  ";

            for (int i = 0; i < startText.Length; i++)
            {
                Console.Write(startText[i]);
                Thread.Sleep(5);
            }

            Console.WriteLine(string.Empty);
            Console.WriteLine("Press Enter to Start");

            Console.ReadLine();
            Console.Clear();

        }

        public static void Intro()
        //Intro to game. Get players name as 'playerName'.
        {

            Console.WriteLine("EVIL VOICE:\r\n" +
                "  I'm an Evil voice \r\n" +
                "  doing Evil things\r\n" +
                "  like giving monsters gold.  \r\n");
            Console.ReadLine();

            /*Console.WriteLine("EVIL VOICE:\r\n" +
                "  To beat me you will need to TRAIN\r\n" +
                "  and get a SWORD\r\n" +
                "  maybe a SHIELD too.\r\n");
            Console.WriteLine("  Do you recall your name?\r\n\r\n");*/

                        
            Console.Write("  Enter your name: ");
            Program.player.name = Console.ReadLine();
            Console.Clear();

                  
            string slayMe = @" 
  Come slay me if you can";

            for (int i = 0; i < slayMe.Length; i++)
            {
                Console.Write(slayMe[i]);
                Thread.Sleep(50);
            }
            Console.Write(" " + Program.player.name);

            Console.ReadLine();

        }

        public static void Part1()
         //Some story or something idk
        {
         /*   Console.Clear();
            Console.WriteLine("A Person approaches");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Person:\n  Is that you?" + " " + Program.player.name);
            Console.WriteLine("Person:\r\n  You came here on time\n  I just hope its not too late\n  ");
            Console.ReadLine();
            Console.WriteLine("Person:\r\n  Oh no, a monster! And he has my gold!");
            Console.ReadLine();
         */ Console.WriteLine("A monster appears. Prepare to battle.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}