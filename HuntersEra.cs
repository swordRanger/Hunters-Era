/*
 * Author: swordRanger (Alias)
 * Date: 1 April 2024 (Created)
 * Game Name: Hunter's Era
 * Description: A text RPG. Idk if it'll be good but I hope it'll be playable.
 *              It is also my first C# project.
 * Future Plans: Hunter's Era Plus: A console-based text/GUI RPG.
 *               Hunter's Era Advanced: Web based RPG with sprites, UI and previous two games.
 *               Game Functions: For now, the text version will temporarily not have save and load functions. *               
 */

using System.Media;
using SoundTracks;

namespace HuntersEra
{

    //The first class that will be instantiated on launch.
    //Essentially the start screen.
    public class GameLauncher
    {
        int playerChoice;

        //GameMusic Class in namespace SoundTracks. See namespace code for more details.
        GameMusic gameMusic = new GameMusic();

        //Displays welcome message upon launch and plays some music. :)
        public void WelcomeMessage()
        {
            gameMusic.LauncherMusic();
            Console.WriteLine("Welcome To Hunter's Era");
            Thread.Sleep(1000);
            Console.Write("Initializing game");
            Console.Write(" .");
            Console.Beep();
            Thread.Sleep(1000);
            Console.Write(" .");
            Console.Beep();
            Thread.Sleep(1000);
            Console.WriteLine(" .");
            Console.Beep();
            Thread.Sleep(600);
        }

        //Interact with the game menu before you start playing.
        public int GameMenu()
        {
            Console.WriteLine("1. Play");
            Console.WriteLine("2. Options");
            Console.WriteLine("3. Credits");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            playerChoice = Convert.ToInt16(Console.ReadLine());

            return playerChoice;
        }
    }

    public class HuntersEra
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan; //Changes console font color.

            GameLauncher startGame = new GameLauncher();
            startGame.WelcomeMessage(); //Display welcome message.

            //Stores value returned when player chooses a menu option.
            int menuSelection = startGame.GameMenu();

            /*switch(menuSelection)
            {
                case 1:
                    *//*Gameplay game = new Gameplay();
                    game.NewGameCreator();*//*
                    break;
                case 2:
                    _ = new GameOptions();
            }*/
        }
    }
}