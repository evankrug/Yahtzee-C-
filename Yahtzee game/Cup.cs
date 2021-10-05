using System;
using System.Collections.Generic;
using System.Text;



namespace Yahtzee_game
{
    public class Cup
    {
        const int NUM_DICE = 5;
        Die[] dice;
      
        
        public Cup()
        {
            //initialize Dice
            for (int i = 0; i < NUM_DICE; i++)
            {
                dice[i] = new Die();
            }

        }

    }
}
