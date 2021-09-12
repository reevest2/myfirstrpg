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
        {  
            Console.WriteLine("A monster appears. Prepare to battle.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}