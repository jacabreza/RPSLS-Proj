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


        // Constructor (SPAWNER)
        public AI()
        {
            PlayerName();
        }

        // Member Methods (CAN DO)

        public override void PlayerName()
        {
            Console.WriteLine("Please pick name for the AI:  ");
            name = Console.ReadLine();
        }

        public override void PlayersGesture()
        {
            Console.WriteLine("Please pick a Gesture from the following: ");
            
            // choose gesture as AI
            // generate random number
        }

    }

}
