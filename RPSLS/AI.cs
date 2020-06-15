using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class AI : Player        //inheritance (IS A TYPE OF)
    {
        // Member Variables (HAS A)
        public Random random;
        public string randomGesture;

        // Constructor (SPAWNER)
        public AI()
        {
            //PlayerName();
        }

        // Member Methods (CAN DO)

        public override void PlayerName()
        {
            Console.WriteLine("Please pick name for the AI:  ");
            name = Console.ReadLine();
        }

        public override string PlayersGesture()
        {
            Console.WriteLine("\n\tComputer's turn to pick a gesture: ");

            for (int i = 0; i < listOfGestures.Count; i++)
            {
                Console.WriteLine((i + 1) + "-" + listOfGestures[i] + " ");
            }
            random = new Random();
            randomGesture = random.Next(1, 5).ToString();

            Console.WriteLine($"\tComputer chose: {randomGesture}");
            return userInput;

            // choose gesture as AI
            // generate random number
        }
    }
}
