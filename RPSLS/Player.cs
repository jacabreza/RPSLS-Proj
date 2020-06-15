using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        // Member Variables (HAS A)
        public int score = 0;
        public string name;
        public string userInput;
        public string choice;
        
        //public int score;

        public List<string> listOfGestures;

        // Constructor (SPAWNER)
        public Player()
        {

            listOfGestures = new List<string>();

            listOfGestures.Add("Rock");
            listOfGestures.Add("Paper");
            listOfGestures.Add("Scissor");
            listOfGestures.Add("Lizard");
            listOfGestures.Add("Spock");
            
        }

        // Member Methods (CAN DO)

        public abstract void PlayerName();


        public abstract string PlayersGesture();
       

    }
        
}
