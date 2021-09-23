using System;
using System.Collections.Generic;
using System.Text;

namespace Yahtzee_game
{
    interface Playable
    {
        void rollDice();
        void holdDice();
        void score();
    }
}
