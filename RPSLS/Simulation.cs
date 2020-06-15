using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Simulation
    {
        // Member Variables (HAS A)
        public Player playerOne;
        public Player playerTwo;
        public bool gameIsWorking;


        // Constructor (SPAWNER)
        public Simulation()
        {
            
            playerOne = new Human();
            gameIsWorking = true;
        }

        // Member Methods (CAN DO)

        public void DisplayWelcome()
        {
            
            Console.WriteLine("\nWelcome to the game of Rock, Paper, Scissor, Lizard, Spock!");
            //Console.ReadLine();
        }


        public void DisplayRules()
        {
            Console.WriteLine("\n\tThe rules are simple: ");
           // Console.ReadLine();
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
           // Console.ReadLine();
            Console.WriteLine("\nNow let's play the Game!!!");
           // Console.ReadLine();
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


        public void CompareGestures()
        {
            
            if (playerOne.choice == "rock")
            {
                if (playerTwo.choice == "scissor")
                {
                    Console.WriteLine("Rock beats Scissors! Player 1 wins the round!");
                    playerOne.score = playerOne.score + 1;
                }
                else if (playerTwo.choice == "lizard")
                {
                    Console.WriteLine("Rock beats Lizard! Player 1 wins the round!");
                    playerOne.score = playerOne.score + 1;
                }
                else if (playerTwo.choice == "paper")
                {
                    Console.WriteLine("Paper beats Rock! Player 2 wins the round!");
                    playerTwo.score = playerTwo.score + 1;
                }
                else if (playerTwo.choice == "spock")
                {
                    Console.WriteLine("Spock beats Rock! Player 2 wins the round!");
                    playerTwo.score = playerTwo.score + 1;
                }
            }
            else if (playerOne.choice == "paper")
            {
                if (playerTwo.choice == "rock")
                {
                    Console.WriteLine("Paper beats Rock! Player 1 wins the round!");
                    playerOne.score = playerOne.score + 1;
                }
                else if (playerTwo.choice == "spock")
                {
                    Console.WriteLine("Paper bests Spock! Player 1 wins the round!");
                    playerOne.score = playerOne.score + 1;
                }
                else if (playerTwo.choice == "lizard")
                {
                    Console.WriteLine("Lizard beats Paper! Player 2 wins the round!");
                    playerTwo.score = playerTwo.score + 1;
                }
                else if (playerTwo.choice == "scissor")
                {
                    Console.WriteLine("Scissor beats Paper! Player 2 wins the round!");
                    playerTwo.score = playerTwo.score + 1;
                }
            }
            else if (playerOne.choice == "scissor")
            {
                if (playerTwo.choice == "paper")
                {
                    Console.WriteLine("Paper beats Paper! Player 1 wins the round!");
                    playerOne.score = playerOne.score + 1;
                }
                else if (playerTwo.choice == "lizard")
                {
                    Console.WriteLine("Paper bests Lizard! Player 1 wins the round!");
                    playerOne.score = playerOne.score + 1;
                }
                else if (playerTwo.choice == "spock")
                {
                    Console.WriteLine("Spock beats Scissors! Player 2 wins the round!");
                    playerTwo.score = playerTwo.score + 1;
                }
                else if (playerTwo.choice == "Rock")
                {
                    Console.WriteLine("Rock beats Scissors! Player 2 wins the round!");
                    playerTwo.score = playerTwo.score + 1;
                }
            }
            else if (playerOne.choice == "lizard")
            {
                if (playerTwo.choice == "paper")
                {
                    Console.WriteLine("Paper beats paper! Player 1 wins the round!");
                    playerOne.score = playerOne.score + 1;
                }
                else if (playerTwo.choice == "spock")
                {
                    Console.WriteLine("Paper bests Spock! Player 1 wins the round!");
                    playerOne.score = playerOne.score + 1;
                }
                else if (playerTwo.choice == "scissor")
                {
                    Console.WriteLine("Scissors beats Lizard! Player 2 wins the round!");
                    playerTwo.score = playerTwo.score + 1;
                }
                else if (playerTwo.choice == "rock")
                {
                    Console.WriteLine("Rock beats Lizard! Player 2 wins the round!");
                    playerTwo.score = playerTwo.score + 1;
                }
            }
            else if (playerOne.choice == "spock")
            {
                if (playerTwo.choice == "scissor")
                {
                    Console.WriteLine("Paper beats Scissors! Player 1 wins the round!");
                    playerOne.score = playerOne.score + 1;
                }
                else if (playerTwo.choice == "rock")
                {
                    Console.WriteLine("Paper bests Rock! Player 1 wins the round!");
                    playerOne.score = playerOne.score + 1;
                }
                else if (playerTwo.choice == "lizard")
                {
                    Console.WriteLine("Lizard beats Spock! Player 2 wins the round!");
                    playerTwo.score = playerTwo.score + 1;
                }
                else if (playerTwo.choice == "paper")
                {
                    Console.WriteLine("Paper beats Spock! Player 2 wins the round!");
                    playerTwo.score = playerTwo.score + 1;
                }
            }

            else if(playerOne.choice == playerTwo.choice)
            {
                Console.WriteLine("Tied!");
            }

            //else
            //{
            // player2 wins
            //}

        }


        public void DisplayWinner()
        {
            if (playerOne.score == 2)
            {
                Console.WriteLine("Player 1 Wins the Game!");
            }
            if (playerTwo.score == 2)
            {
                Console.WriteLine("Player 2 Wins the Game!");
            }

        }
        

        public void RunGame()          
        {
            DisplayWelcome();
            
            DisplayRules();
            
            ChooseGameMode();


            while (gameIsWorking)
            {

                playerOne.choice = playerOne.PlayersGesture().ToLower();
                playerTwo.choice = playerTwo.PlayersGesture().ToLower();

                CompareGestures();

                if (playerOne.score == 2 || playerTwo.score == 2)
                {
                    gameIsWorking = false;
                }
                

            }
           
            DisplayWinner();



            //\\ 0. Intro to game
            //\\ 1. Display rules for game
            //\\ 2. Choose Game Mode (P v P) (P v Com.) 
                //\\ a. Ask for which game mode 
                //\\ b. Capture answer from user
                //\\ c. Make our player objects
            //\\ 3. Choose name for Players   
            //\\4. Choose a gesture for Player 1     
            //\\5. Choose a gesture for Player 2     
            // 6. Compare the 2 chosen gestures     (SIM)
                //\\ This determines who won the round
            // 7. Check to see if player won the game   (SIM)
            // 8. Repeat 4. - 6.        
            // 9. Display Winner / Game Result      (SIM)
        }

    }
        
}
