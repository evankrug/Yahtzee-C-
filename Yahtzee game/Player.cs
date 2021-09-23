using System;
using System.Collections.Generic;
using System.Text;

namespace Yahtzee_game
{
    public class Player : Playable
    {
        string name;
        public Player(string name)
        {
            this.name = name;
        }
        public void holdDice()
        {
            throw new NotImplementedException();
        }

        public void rollDice()
        {
            throw new NotImplementedException();
        }

        public void score()
        {
            throw new NotImplementedException();
        }
    }
}
