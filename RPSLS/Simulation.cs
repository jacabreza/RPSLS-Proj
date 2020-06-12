using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Simulation
    {
        // Member Variables (HAS A)
        public Player playerOne;
        public Player playerTwo;

        // Constructor (SPAWNER)
        public Simulation()
        {
            playerOne = new Human();
            
        }

        // Member Methods (CAN DO)

        public void DisplayWelcome()
        {
            Console.WriteLine("\nWelcome to the game of Rock, Paper, Scissor, Lizard, Spock!");
            Console.ReadLine();
        }


        public void DisplayRules()
        {
            Console.WriteLine("\n\tThe rules are simple: ");
            Console.ReadLine();
            Console.WriteLine("Rock beats Scissors" +
                "\n Rock beats Lizard" +
                "\n Paper beats Rock" +
                "\n Paper beats Spock" +
                "\n Scissors beats Paper" +
                "\n Scissors beats Lizard" +
                "\n Lizard beats Paper" +
                "\n Lizard beats Spock" +
                "\n Spock beats Scissors" +
                "\n Spock beats Rock");
            Console.ReadLine();
            Console.WriteLine("\nNow let's play the Game!!!");
            Console.ReadLine();
        }


        public void ChooseGameMode()
        {
            Console.WriteLine("\n\tPick a Game Mode:");
            Console.WriteLine("\nEnter 1 for Human Vs. AI");
            Console.WriteLine("Enter 2 for Human Vs. Human.");

            string input = Console.ReadLine();

            if (input == "1")
            {
                    Console.WriteLine("You have picked: Human Vs. AI");
                    playerTwo = new AI();
            }
            else if (input == "2")
            {
                    Console.WriteLine("You have picked: Human Vs. Human");
                    playerTwo = new Human();
            }
            else
            {
                while (input != "1" && input != "2")
                {
                   Console.WriteLine("You picked an invalid number! " + "Please Enter 1 for: Human Vs. AI." + " or Enter 2 for: Human Vs. Human");
                   input = Console.ReadLine();

                   if (input == "1")
                   {
                       Console.WriteLine("You have picked: Human Vs. AI");
                       playerTwo = new AI();
                   }
                   else if (input == "2")
                   {
                       Console.WriteLine("You have picked: Human Vs. Human");
                       playerTwo = new Human();
                   }

                }

            }
            
        }


        public void RunGame()           //Master Method - All Methods come together here
        {
            DisplayWelcome();
            DisplayRules();
            ChooseGameMode();
            
            playerOne.PlayersGesture();
            playerTwo.PlayersGesture();


            //\\ 0. Intro to game
            //\\ 1. Display rules for game
            //\\ 2. Choose Game Mode (P v P) (P v Com.) 
                //\\ a. Ask for which game mode 
                //\\ b. Capture answer from user
                //\\ c. Make our player objects
            //\\ 3. Choose name for Players   (PLAYER)
            // 4. Choose a gesture for Player 1     (PLAYER)
            // 5. Choose a gesture for Player 2     (PLAYER)
            // 6. Compare the 2 chosen gestures     (GAME)
                // This determines who won the game
            // 7. Check to see if player won the game   (GAME)
            // 8. Repeat 4. - 6.        
            // 9. Display Winner / Game Result      (GAME)
        }

    }
        
}
