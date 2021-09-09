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
            /*  @@@@@@~~~~~BAD WAY OF DOING THIS~~~~~@@@@@@@
            //int x = 75; //time to wait before loading next line in ms
            Console.WriteLine("    ___________________________________________ ");
            Thread.Sleep(Global.x);
            Console.WriteLine("   ||~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|");
            Thread.Sleep(Global.x);
            Console.WriteLine("   ||  ###### ########   #### #######  ########|");
            Thread.Sleep(Global.x);
            Console.WriteLine("   || ###  ## #  ###    #####  ###  ## #  ###  |");
            Thread.Sleep(Global.x);
            Console.WriteLine("   || ####       ###   ## ###  ###  ##    ###  |");
            Thread.Sleep(Global.x);
            Console.WriteLine("   ||  #####     ###  ##  ###  ######     ###  |");
            Thread.Sleep(Global.x);
            Console.WriteLine("   ||    ####    ### ########  ### ##     ###  |");
            Thread.Sleep(Global.x);
            Console.WriteLine("   || ##  ###    ### ##   ###  ###  ##    ###  |");
            Thread.Sleep(Global.x);
            Console.WriteLine("   ||  #####     ### ##   ###  ###  ##    ###  |");
            Thread.Sleep(Global.x);
            Console.WriteLine("   ||                 ###            ##        |");
            Thread.Sleep(Global.x);
            Console.WriteLine("   ||__________________________________________|");
            Thread.Sleep(Global.x);
            Console.WriteLine("    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(String.Empty);
            Console.WriteLine(" Press Enter to Start");
            */

        
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
        //Intro to game. Random Mars Volta Lyrics. Get players name as 'playerName'.
        {

            Console.WriteLine("MYSTERIOUS VOICE:\r\n" +
                "  It’s been thirteen seconds \r\n" +
                "  since you all last said \r\n" +
                "  I’ve become the apparition \r\n" +
                "  You predicted for my death");
            Console.ReadLine();

            Console.WriteLine("MYSTERIOUS VOICE:\r\n" +
                "  She said, I\'ll never let them hurt you\r\n" +
                "  I\'ll never let them in\r\n" +
                "  What you took from me is mine\r\n" +
                "  And what is mine I\'ll never give.");
            Console.ReadLine();

            Console.WriteLine("MYSTERIOUS VOICE\r\n" +
                "  Do you recall it\'s name? \r\n" 
                //"  As it suggested beck and call\r\n" +
                //"  This face and heel\r\n" +
                //"  Will drag your halo through the mud\r\n\r\n"
                );
         

            Console.Write("Enter your name: ");
            Program.currentPlayer.name = Console.ReadLine();
            Console.Clear();

            /*
                Console.WriteLine("MYSTERIOUS VOICE:\r\n" +
                "  And when " + Program.currentPlayer.name +" sang\r\n" +
                "  Everyone turned away\r\n" +
                "  Used to the noose they obey");
            */
            string dragYourHalo = @" 
  This face and heel
  Will drag your halo through the mud!!!";

            Console.WriteLine("MYSTERIOUS VOICE: ");
            Console.Write("  " + Program.currentPlayer.name + "....");

            for (int i = 0; i < dragYourHalo.Length; i++)
            {
                Console.Write(dragYourHalo[i]);
                Thread.Sleep(50);
            }

               

            Console.ReadLine();
            
        }

        public static void Part1()
         //Some story or something idk
        {
            Console.Clear();
            Console.WriteLine("You awake from your sleep.\nThe mysterious voice still lingers in your mind.\nLike is any of this for real, or not\nOr just random song lyrics....\n");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You hear a voice. A Person approaches");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Person:\n  Is that you?\r\n " + " " + Program.currentPlayer.name);
            Console.WriteLine("Person:\r\n  You came here on time\n  I just hope its not too late\n  I\'ve seen you at night\n  Biting the frost of silence\n  Can you cure us of this fate\n  Mock the litany in its face");
            Console.ReadLine();
            Console.WriteLine("Person:\r\n  Oh no, a monster!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("A monster appears. Prepare to battle.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}