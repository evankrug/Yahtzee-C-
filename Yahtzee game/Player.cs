using System;
using System.Collections.Generic;
using System.Text;

namespace Yahtzee_game
{
    public class Player : Playable
    {
        int id;
        int turns;
        public Player(int id)
        {
            this.id = id;
            turns = 0;
        }
        public void HoldDice()
        {
            throw new NotImplementedException();
        }

        public void RollDice()
        {
            throw new NotImplementedException();
        }

        public void Score()
        {
            throw new NotImplementedException();
        }
        public int GetTurns()
        {
            return this.turns;
        }
        public void IncTurns()
        {
            ++this.turns;
        }
    }
}
