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

           
            random = new Random();
            int index = random.Next(0, 5);
            string chosenGesture = listOfGestures[index];

            Console.WriteLine($"\tComputer chose: {chosenGesture}");
            return chosenGesture;

            // choose gesture as AI
            // generate random number
        }
    }
}
