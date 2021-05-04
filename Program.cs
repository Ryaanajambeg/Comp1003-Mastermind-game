using System;

namespace Comp1003_Mastermind_game
{
    class MastermindGame
    {
        
        private static bool Active; //boolean variable to see if the mastermind is active or not










        private string PlayerInput; // what the player inputs in the console



        static void Main(string[] args)
        {
            MastermindGame game = new MastermindGame();
            string input = string.Empty;
            Console.WriteLine("Welcome to the Mastermind Game!" + Environment.NewLine + "Please input your command");
        }



        private string FirstInput()
        {

            PlayerInput = ""; // input is nothing at start
            PlayerInput = Console.ReadLine(); // read what the player inputs from the console
            Console.Clear(); // console clears after each input

            return PlayerInput;

        }
    }
}
