using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {
        // Member Variables (HAS A)
        public Gestures Gestures;
        //public int score;

        public List<Gestures> listOfGestures;

        // Constructor (SPAWNER)
        public Player()
        {
            int playerOne = 0;
            int playerTwo = 0;

            listOfGestures = new List<Gestures>();

            listOfGestures.Add(new Gestures("Rock"));
            listOfGestures.Add(new Gestures("Paper"));
            listOfGestures.Add(new Gestures("Scissor"));
            listOfGestures.Add(new Gestures("Lizard"));
            listOfGestures.Add(new Gestures("Spock"));
        }

        // Member Methods (CAN DO)
        public abstract void PlayersGesture();
        
            
        
    }
}
