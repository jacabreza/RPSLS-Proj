﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player     //inheritance (IS A TYPE OF)
    {
        // Member Variables (HAS A)

        // Constructor (SPAWNER)
        public Human()
        {
            //PlayerName();
        }

        // Member Methods (CAN DO)

        public override void PlayerName()
        {
            Console.WriteLine("Please type in a name: ");
            name = Console.ReadLine();
        }

        public override string PlayersGesture()
        {
            Console.WriteLine("\nPick a Gesture from the folow: ");

            for (int i = 0; i < listOfGestures.Count; i++)
            {
                Console.WriteLine((i + 1) + "-" + listOfGestures[i] + " ");
            }
            userInput = Console.ReadLine();
            return userInput;

            // choose gesture as human
        }
    }
}
