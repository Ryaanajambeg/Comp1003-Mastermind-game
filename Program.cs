using System;

namespace Comp1003_Mastermind_game
{
    class Program
    {
        
        private static bool Active; //boolean variable to see if the mastermind is active or not










        private string PlayerInput; // what the player inputs in the console



        static void Main(string[] args)
        {
            
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
