using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_game
{
    class Turn
    {
        Player player;
        const int ROLLS = 3;
        public Turn(Player player)
        {
            this.player = player;
        }
    }
}
