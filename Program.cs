using System;

namespace Constructors_Hutton_Riley
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assigns a string the the title and genre
            Game myGame = new Game("CS:GO", "FPS");

            //Prints the favorite game to console
            Console.WriteLine($"My favorite game is {myGame.title} and it is a {myGame.genre} game!");

            //Assigns other game
            Game myOtherGame = new Game();

            //Prtints other game to console
            Console.WriteLine($"My other favorite game is {myOtherGame.title} and it is a {myOtherGame.genre} game!");

        }
    }
}
