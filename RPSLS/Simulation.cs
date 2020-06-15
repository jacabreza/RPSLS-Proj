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
        public int playerOneScore;
        public int playerTwoScore;
        public bool gameIsWorking;


        // Constructor (SPAWNER)
        public Simulation()
        {
            playerOneScore = 0;
            playerTwoScore = 0;
            playerOne = new Human();
            gameIsWorking = true;
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


        public void CompareGestures()
        {
            
            if (playerOne.choice.ToLower() == "rock")
            {
                if (playerTwo.choice.ToLower() == "scissors")
                {
                    Console.WriteLine("Rock beats Scissors! Player 1 wins the round!");
                    playerOneScore = playerOneScore + 1;
                }
                else if (playerTwo.choice.ToLower() == "lizard")
                {
                    Console.WriteLine("Rock beats Lizard! Player 1 wins the round!");
                    playerOneScore = playerOneScore + 1;
                }
                else if (playerTwo.choice.ToLower() == "paper")
                {
                    Console.WriteLine("Paper beats Rock! Player 2 wins the round!");
                    playerTwoScore = playerTwoScore + 1;
                }
                else if (playerTwo.choice.ToLower() == "spock")
                {
                    Console.WriteLine("Spock beats Rock! Player 2 wins the round!");
                    playerTwoScore = playerTwoScore + 1;
                }
            }
            else if (playerOne.choice.ToLower() == "paper")
            {
                if (playerTwo.choice.ToLower() == "rock")
                {
                    Console.WriteLine("Paper beats Rock! Player 1 wins the round!");
                    playerOneScore = playerOneScore + 1;
                }
                else if (playerTwo.choice.ToLower() == "spock")
                {
                    Console.WriteLine("Paper bests Spock! Player 1 wins the round!");
                    playerOneScore = playerOneScore + 1;
                }
                else if (playerTwo.choice.ToLower() == "lizard")
                {
                    Console.WriteLine("Lizard beats Paper! Player 2 wins the round!");
                    playerTwoScore = playerTwoScore + 1;
                }
                else if (playerTwo.choice.ToLower() == "scissor")
                {
                    Console.WriteLine("Scissor beats Paper! Player 2 wins the round!");
                    playerTwoScore = playerTwoScore + 1;
                }
            }
            else if (playerOne.choice.ToLower() == "scissors")
            {
                if (playerTwo.choice.ToLower() == "paper")
                {
                    Console.WriteLine("Paper beats Paper! Player 1 wins the round!");
                    playerOneScore = playerOneScore + 1;
                }
                else if (playerTwo.choice.ToLower() == "lizard")
                {
                    Console.WriteLine("Paper bests Lizard! Player 1 wins the round!");
                    playerOneScore = playerOneScore + 1;
                }
                else if (playerTwo.choice.ToLower() == "spock")
                {
                    Console.WriteLine("Spock beats Scissors! Player 2 wins the round!");
                    playerTwoScore = playerTwoScore + 1;
                }
                else if (playerTwo.choice.ToLower() == "Rock")
                {
                    Console.WriteLine("Rock beats Scissors! Player 2 wins the round!");
                    playerTwoScore = playerTwoScore + 1;
                }
            }
            else if (playerOne.choice.ToLower() == "lizard")
            {
                if (playerTwo.choice.ToLower() == "paper")
                {
                    Console.WriteLine("Paper beats paper! Player 1 wins the round!");
                    playerOneScore = playerOneScore + 1;
                }
                else if (playerTwo.choice.ToLower() == "spock")
                {
                    Console.WriteLine("Paper bests Spock! Player 1 wins the round!");
                    playerOneScore = playerOneScore + 1;
                }
                else if (playerTwo.choice.ToLower() == "scissors")
                {
                    Console.WriteLine("Scissors beats Lizard! Player 2 wins the round!");
                    playerTwoScore = playerTwoScore + 1;
                }
                else if (playerTwo.choice.ToLower() == "rock")
                {
                    Console.WriteLine("Rock beats Lizard! Player 2 wins the round!");
                    playerTwoScore = playerTwoScore + 1;
                }
            }
            else if (playerOne.choice.ToLower() == "spock")
            {
                if (playerTwo.choice.ToLower() == "scissors")
                {
                    Console.WriteLine("Paper beats Scissors! Player 1 wins the round!");
                    playerOneScore = playerOneScore + 1;
                }
                else if (playerTwo.choice.ToLower() == "rock")
                {
                    Console.WriteLine("Paper bests Rock! Player 1 wins the round!");
                    playerOneScore = playerOneScore + 1;
                }
                else if (playerTwo.choice.ToLower() == "lizard")
                {
                    Console.WriteLine("Lizard beats Spock! Player 2 wins the round!");
                    playerTwoScore = playerTwoScore + 1;
                }
                else if (playerTwo.choice.ToLower() == "paper")
                {
                    Console.WriteLine("Paper beats Spock! Player 2 wins the round!");
                    playerTwoScore = playerTwoScore + 1;
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
            if (playerOneScore == 2)
            {
                Console.WriteLine("Player 1 Wins the Game!");
            }
            if (playerTwoScore == 2)
            {
                Console.WriteLine("PLayer 2 Wins the Game!");
            }

        }
        

        public void RunGame()          
        {
            DisplayWelcome();
            
            DisplayRules();
            
            ChooseGameMode();

            playerOne.PlayersGesture();
            playerTwo.PlayersGesture();

            CompareGestures();

            while (gameIsWorking)
            {
                //playerOne.PlayersGesture();
                //playerTwo.PlayersGesture();


                if (playerOneScore == 2 || playerTwoScore == 2)
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
